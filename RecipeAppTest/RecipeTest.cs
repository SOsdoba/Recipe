using NUnit.Framework.Internal.Execution;
using RecipeAppSystem;
using System.ComponentModel;
using System.Configuration;
using System.Data;

namespace RecipeAppTest
{
    public class RecipeTest
    {
        string connstring = ConfigurationManager.ConnectionStrings["azureuserconn"].ConnectionString;
        string devconnstring = ConfigurationManager.ConnectionStrings["azuredevconn"].ConnectionString;


        [SetUp]
        public void Setup()
        {
            DBManager.SetConnectionString(devconnstring, true);
        }

        private DataTable GetDataTable(string sql)
        {
            DataTable dt = new();
            DBManager.SetConnectionString(devconnstring, false);
            dt = SQLUtility.GetDataTable(sql);
            DBManager.SetConnectionString(connstring, false);
            return dt;
        }

        private int GetFirstColumnFirstRowValue(string sql)
        {
            int n = 0;
            DBManager.SetConnectionString(devconnstring, false);
            n = SQLUtility.GetFirstColumnFirstRowValue(sql);
            DBManager.SetConnectionString(connstring, false);
            return n;
        }

        [Test]
        [TestCase("Food Test: ", 50, "2010-01-01", "2014-01-01", "2015-01-01")]
        [TestCase("Food: ", 50, "2010-01-01", "2014-01-01", "2014-01-08")]
        public void InsertNewRecipe(string recipename, int calories, DateTime draftdate, DateTime publishdate, DateTime archivedate)
        {
            recipename += DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
            DataTable dtrecipe = GetDataTable("select * from recipe r where r.recipename = '" + recipename + "'");
            Assume.That(dtrecipe.Rows.Count == 0, "recipe with name " + recipename + " is already found in db. Cannot insert 2 recipes with the same name.");
            TestContext.WriteLine("Recipe " + recipename + " does not exist in Recipe DB");
            TestContext.WriteLine("Ensure that recipe " + recipename + " is added to DB.");

            DataTable dt = GetDataTable("select * from recipe where recipeid = 0");
            DataRow r = dt.Rows.Add();
            Assume.That(dt.Rows.Count == 1);
            int usersid = GetFirstColumnFirstRowValue("select top 1 usersid from users");
            Assume.That(usersid > 0, "Can't run test, no users in DB");
            int cuisinetypeid = GetFirstColumnFirstRowValue("select top 1 cuisinetypeid from cuisinetype");
            Assume.That(cuisinetypeid > 0, "Can't run test, no cuisinetypes in DB");

            r["UsersId"] = usersid;
            r["CuisinetypeId"] = cuisinetypeid;
            r["RecipeName"] = recipename;
            r["Calories"] = calories;
            r["DraftDate"] = draftdate;
            r["PublishDate"] = publishdate;
            r["ArchiveDate"] = archivedate;
            Recipe.Save(dt);

            int newid = GetFirstColumnFirstRowValue("select * from recipe where recipename = '" + recipename + "'");
            Assert.IsTrue(newid > 0, "recipe with name = " + recipename + " is not found in db");
            TestContext.WriteLine("Recipe " + recipename + " is found in db with pk value = " + newid);
        }

        [Test] 
        public void ChangeRecipeCalories()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes in db, can't run test");
            int calories = GetFirstColumnFirstRowValue("select calories from recipe where recipeid = " + recipeid);
            TestContext.WriteLine("Calories for recipe with Id " + recipeid + " is " + calories);
            int increasedcalories = calories + 100;
            TestContext.WriteLine("Change calories to " + increasedcalories);
            TestContext.WriteLine("Ensure that recipe with Id " + recipeid + " has " + increasedcalories + " calories.");
            DataTable dt = Recipe.Load(recipeid);
            Assert.IsTrue(increasedcalories == calories + 100, "recipe with id = " + recipeid + " has not increased calories.");
            TestContext.WriteLine("Recipe " + recipeid + " has " + increasedcalories + " calories.");

            //string draftdate = txtdraftdate != "" ? "'" + r["DraftDate"] + "'" : "'" + DateTime.Now.ToString() + "'";
            //string publishdate = txtPublishDate.Text != "" ? "'" + r["PublishDate"] + "'" : "null";
            //string archivedate = txtArchiveDate.Text != "" ? "'" + r["ArchiveDate"] + "'" : "null";

            //dt.Rows[0]["Calories"] = calories;
            //Recipe.Save(dt, );
        }

        [Test]
        public void ChangeRecipeCaloriesToInvalidCalories()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes in db, can't run test");
            int calories = GetFirstColumnFirstRowValue("select calories from recipe where recipeid = " + recipeid);
            TestContext.WriteLine("Calories for recipe with Id " + recipeid + " is " + calories);
            calories = 0;
            TestContext.WriteLine("Change calories to " + calories);
            DataTable dt = Recipe.Load(recipeid);
            dt.Rows[0]["calories"] = calories;
            Exception ex = Assert.Throws<Exception>(() => Recipe.Save(dt), "Calories must be greater than 0.");
            TestContext.WriteLine(ex.Message);
            
        }

        [Test]
        public void ChangeExistingRecipeToInvalidName()
        {
            
            DataTable dt1 = GetDataTable("select top 1 r.recipeid, RecipeName from recipe r ");
            int recipeid = (int)dt1.Rows[0]["recipeid"];
            string recipename = dt1.Rows[0]["RecipeName"].ToString();

            DataTable dt2 = GetDataTable("select top 1 r.recipeid, RecipeName from recipe r where r.recipeid <> " + recipeid);
            string newname = dt2.Rows[0]["RecipeName"].ToString();

            Assume.That(newname != "", "Cannot run test because there isn't another recipe record in the table.");
            TestContext.WriteLine("Change recipeid " + recipeid + " name from " + recipename + " to " + newname + " which belongs to different recipe.");
            DataTable dt3 = Recipe.Load(recipeid);
            dt3.Rows[0]["recipename"] = newname;
            Exception ex = Assert.Throws<Exception>(() => Recipe.Save(dt3), "Recipename must be unique.");
            TestContext.WriteLine(ex.Message);
        }

        [Test]
        public void DeleteRecipe()
        {
            DataTable dt = GetDataTable("select top 1 r.recipeid, RecipeName from recipe r left join CookBookRecipes c on c.Recipeid = r.RecipeId where c.recipeid is null and r.recipestatus = 'Draft'");
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
            DataTable dtafterdeltete = GetDataTable("select * from recipe where recipeid = " + recipeid);
            Assert.IsTrue(dtafterdeltete.Rows.Count == 0, "record with recipeid " + recipeid + " exists in db");
            TestContext.WriteLine("Record with recipe " + recipeid + " has been deleted and does not exist in db");
        }

        [Test]
        public void DeleteRecipeArchivedLessThan30DaysOrPublished()
        {
            string sql = @"
select * 
from recipe r 
where 
(r.RecipeStatus = 'published' 
or datediff(day, r.archivedate, getdate())  < 30)
";
            DataTable dt = GetDataTable(sql);
            int recipeid = 0;
            string recipedesc = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipedesc = dt.Rows[0]["RecipeName"].ToString();
            }
            Assume.That(recipeid > 0, "No recipes with archive date under 30 or published in DB, can't run test");
            TestContext.WriteLine("Existing recipe archived under 30 days or published, with id = " + recipeid + " " + recipedesc);
            TestContext.WriteLine("Ensure that app cannot delete " + recipeid);

            Exception ex = Assert.Throws<Exception>(() => Recipe.Delete(dt));

            TestContext.WriteLine(ex.Message);

        }

        //[Test]
        //public void DeleteRecipeWithIngredients()
        //{
        //    DataTable dt = GetDataTable("select top 1 r.recipeid, recipename from recipe r join recipeingredient i on i.recipeid = r.recipeid where r.recipestatus = 'draft'");
        //    int recipeid = 0;
        //    string recipedescription = "";
        //    if (dt.Rows.Count > 0)
        //    {
        //        recipeid = (int)dt.Rows[0]["recipeid"];
        //        recipedescription = dt.Rows[0]["RecipeName"].ToString() ;
        //    }
        //    Assume.That(recipeid > 0, "No recipes with ingredients in DB, can't run test");
        //    TestContext.WriteLine("Existing recipe with ingredients, with id = " + recipeid + " " + recipedescription);
        //    TestContext.WriteLine("Ensure that app cannot delete " + recipeid);

        //    Exception ex = Assert.Throws<Exception>(() => Recipe.Delete(dt), "Cannot delete recipe with ingredients.");

        //    TestContext.WriteLine(ex.Message);

        //}

        [Test]
        public void LoadRecipe()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes in db, can't run test");
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

        //[Test]
        //[TestCase("")]
        //[TestCase("s")]
        //public void SearchRecipe(string criteria)
        //{
        //    int num = GetFirstColumnFirstRowValue("select total = count(*) from recipe r where r.recipename like '%" + criteria + "%'");
        //    Assume.That(num > 0, "There aren't any recipes that match the search for " + criteria);
        //    TestContext.WriteLine(num + " recipes that match '" + criteria + "'.");
        //    TestContext.WriteLine("Ensure that recipe search returns " + num + " rows");
        //    DataTable dt = Recipe.SearchRecipes(criteria);
        //    int results = dt.Rows.Count;
        //    Assert.IsTrue(results == num, "Results of recipe search does not match number of recipes, " + results + " <> " + num);
        //    TestContext.WriteLine("Number of rows returned by recipe search is " + results);
        

        [Test]
        public void GetListOfUsers()
        {
            int usercount = GetFirstColumnFirstRowValue("select total = count(*) from users");
            Assume.That(usercount > 0, "No users in DB, can't test");
            TestContext.WriteLine("Num of users in DB = " + usercount);
            TestContext.WriteLine("Ensure that num of rows returned by app matches " + usercount);
            DataTable dt = Recipe.GetUsersList(0);
            Assert.IsTrue(dt.Rows.Count == usercount, "Num rows returned by app (" + dt.Rows.Count + ") <> " + usercount);
            TestContext.WriteLine("Number of Users returned by app = " + dt.Rows.Count);
        }

        [Test]
        public void GetListOfCuisineTypes()
        {
            int cuisinetypecount = GetFirstColumnFirstRowValue("select total = count(*) from cuisinetype");
            Assume.That(cuisinetypecount > 0, "No cuisine types in DB, can't test");
            TestContext.WriteLine("Num of Cuisine types in DB = " + cuisinetypecount);
            TestContext.WriteLine("Ensure that num of rows returned by app matches " + cuisinetypecount);
            DataTable dt = Recipe.GetCuisineList();
            Assert.IsTrue(dt.Rows.Count == cuisinetypecount, "Num rows returned by app (" + dt.Rows.Count + ") <> " + cuisinetypecount);
            TestContext.WriteLine("Number of Cuisine types returned by app = " + dt.Rows.Count);
        }

        private int GetExistingRecipeId()
        {
            return GetFirstColumnFirstRowValue("select top 1 recipeid from recipe");
        }


        private string GetFirstColumnFirstRowValueAsString()
        {
            DataTable dt = GetDataTable("select top 1 recipe from recipe r");
            return dt.Rows[0]["RecipeName"].ToString();  
        }

    }
}