using NUnit.Framework.Internal.Execution;
using RecipeAppSystem;
using System.Data;

//Best practice is to follow these guidelines - Tests should be self-documenting:
//Test output should include:
//•state prior to test
//•desired outcome
//•state after test
//please make sure to follow these guidelines for the tests below, some of them are missing one or more of the above


namespace RecipeAppTest
{
    public class RecipeTest
    {
        
        [SetUp]
        public void Setup()
        {
            DBManager.SetConnectionString("Server=.\\SQLExpress;Database=RecipeDB;Trusted_Connection=true");
        }

        [Test]
        [TestCase("Food Test: ", 50, "2010-01-01", "2014-01-01", "2015-01-01")]
        [TestCase("Food: ", 50, "2010-01-01", "2014-01-01", "2014-01-08")]
        public void InsertNewRecipe(string recipename, int calories, DateTime draftdate, DateTime publishdate, DateTime archivedate)
        {
            recipename += DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
            DataTable dtrecipe = SQLUtility.GetDataTable("select * from recipe r where r.recipename = '" + recipename + "'");
            Assume.That(dtrecipe.Rows.Count == 0, "recipe with name " + recipename + " is already found in db. Cannot insert 2 recipes with the same name.");
            TestContext.WriteLine("Recipe " + recipename + " does not exist in Recipe DB");
            TestContext.WriteLine("Ensure that recipe " + recipename + " is added to DB.");

            DataTable dt = SQLUtility.GetDataTable("select * from recipe where recipeid = 0");
            DataRow r = dt.Rows.Add();
            Assume.That(dt.Rows.Count == 1);
            int usersid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 usersid from users");
            Assume.That(usersid > 0, "Can't run test, no users in DB");
            int cuisinetypeid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 cuisinetypeid from cuisinetype");
            Assume.That(cuisinetypeid > 0, "Can't run test, no cuisinetypes in DB");

            r["UsersId"] = usersid;
            r["CuisinetypeId"] = cuisinetypeid;
            r["RecipeName"] = recipename;
            r["Calories"] = calories;
            r["DraftDate"] = draftdate;
            r["PublishDate"] = publishdate;
            r["ArchiveDate"] = archivedate;
            Recipe.Save(dt);

            int newid = SQLUtility.GetFirstColumnFirstRowValue("select * from recipe where recipename = '" + recipename + "'");
            Assert.IsTrue(newid > 0, "recipe with name = " + recipename + " is not found in db");
            TestContext.WriteLine("Recipe " + recipename + " is found in db with pk value = " + newid);
        }

        [Test] 
        public void ChangeRecipeCalories()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes in db, can't run test");
            int calories = SQLUtility.GetFirstColumnFirstRowValue("select calories from recipe where recipeid = " + recipeid);
            TestContext.WriteLine("Calories for recipe with Id " + recipeid + " is " + calories);
            int increasedcalories = calories + 100;
            TestContext.WriteLine("Change calories to " + increasedcalories);
            TestContext.WriteLine("Ensure that recipe with Id " + recipeid + " has " + increasedcalories + " calories.");
            DataTable dt = Recipe.Load(recipeid);
            Assert.IsTrue(increasedcalories == calories + 100, "recipe with id = " + recipeid + " has not increased calories.");
            TestContext.WriteLine("Recipe " + recipeid + " has " + increasedcalories + " calories.");
            //AF YOu need to assert that the test successfully changed the recipe calories to the desired amount

            //string draftdate = txtdraftdate != "" ? "'" + r["DraftDate"] + "'" : "'" + DateTime.Now.ToString() + "'";
            //string publishdate = txtPublishDate.Text != "" ? "'" + r["PublishDate"] + "'" : "null";
            //string archivedate = txtArchiveDate.Text != "" ? "'" + r["ArchiveDate"] + "'" : "null";

            //dt.Rows[0]["Calories"] = calories;
            //Recipe.Save(dt, );
        }

        [Test]
        public void DeleteRecipe()
        {
            DataTable dt = SQLUtility.GetDataTable("select top 1 r.recipeid, RecipeName from recipe r left join CookBookRecipes c on c.Recipeid = r.RecipeId where c.recipeid is null");
            int recipeid = 0;
            string recipename = "";
            if(dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipename = dt.Rows[0]["RecipeName"].ToString();
            }
            Assume.That(recipeid > 0, "No recipes without connection to a cookbook, can't run test");
            TestContext.WriteLine("Record with recipe " + recipeid + "exits in db. (Does not have connection to cookbook).");
            TestContext.WriteLine("Ensure that app can delete " + recipeid);
            Recipe.Delete(dt);
            DataTable dtafterdeltete = SQLUtility.GetDataTable("select * from recipe where recipeid = " + recipeid);
            Assert.IsTrue(dtafterdeltete.Rows.Count == 0, "record with recipeid " + recipeid + " exists in db");
            TestContext.WriteLine("Record with recipe " + recipeid + " has been deleted and does not exist in db");
        }

        [Test]
        public void LoadRecipe()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes in db, can't run test");
            //AF TestContext.Write writes the string but doesn't include a line break after, so it looks like this message
            //and the message below are one message, since they are on one line.  I recommend using WriteLine() instead
            TestContext.WriteLine("Existing recipe with id = " + recipeid);
            TestContext.WriteLine("Ensure that app loads recipe " + recipeid);
            DataTable dt = Recipe.Load(recipeid);
            int loadedid = 0;
            if (dt.Rows.Count > 0)
            {
                loadedid = (int)dt.Rows[0]["recipeid"];
            }
            Assert.IsTrue(loadedid == recipeid, loadedid + " <> " + recipeid);
            TestContext.WriteLine("Loaded recipe (" + loadedid + ")");
        }

        [Test]
        [TestCase("")]
        [TestCase("s")]
        public void SearchRecipe(string criteria)
        {
            int num = SQLUtility.GetFirstColumnFirstRowValue("select total = count(*) from recipe r where r.recipename like '%" + criteria + "%'");
            //AF The message below has a mistake, it should say there arent recipes that match the search for criteria, not the 'num' variable's value
            Assume.That(num > 0, "There aren't any recipes that match the search for " + criteria);
            TestContext.WriteLine(num + " recipes that match '" + criteria + "'.");
            TestContext.WriteLine("Ensure that recipe search returns " + num + " rows");
            DataTable dt = Recipe.SearchRecipes(criteria);
            int results = dt.Rows.Count;
            Assert.IsTrue(results == num, "Results of recipe search does not match number of recipes, " + results + " <> " + num);
            TestContext.WriteLine("Number of rows returned by recipe search is " + results);
        }

        [Test]
        public void GetListOfUsers()
        {
            int usercount = SQLUtility.GetFirstColumnFirstRowValue("select total = count(*) from users");
            Assume.That(usercount > 0, "No users in DB, can't test");
            TestContext.WriteLine("Num of users in DB = " + usercount);
            TestContext.WriteLine("Ensure that num of rows returned by app matches " + usercount);
            DataTable dt = Recipe.GetUsersList();
            Assert.IsTrue(dt.Rows.Count == usercount, "Num rows returned by app (" + dt.Rows.Count + ") <> " + usercount);
            TestContext.WriteLine("Number of Users returned by app = " + dt.Rows.Count);
        }

        [Test]
        public void GetListOfCuisineTypes()
        {
            int cuisinetypecount = SQLUtility.GetFirstColumnFirstRowValue("select total = count(*) from cuisinetype");
            Assume.That(cuisinetypecount > 0, "No cuisine types in DB, can't test");
            TestContext.WriteLine("Num of Cuisine types in DB = " + cuisinetypecount);
            TestContext.WriteLine("Ensure that num of rows returned by app matches " + cuisinetypecount);
            DataTable dt = Recipe.GetCuisineList();
            Assert.IsTrue(dt.Rows.Count == cuisinetypecount, "Num rows returned by app (" + dt.Rows.Count + ") <> " + cuisinetypecount);
            TestContext.WriteLine("Number of Cuisine types returned by app = " + dt.Rows.Count);
        }

        private int GetExistingRecipeId()
        {
            return SQLUtility.GetFirstColumnFirstRowValue("select top 1 recipeid from recipe");
        }

    }
}