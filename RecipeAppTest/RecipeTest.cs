using System.Configuration;
using System.Data;

namespace RecipeAppTest
{
    public class RecipeTest
    {
        string devconnstring = ConfigurationManager.ConnectionStrings["devconn"].ConnectionString;
        string unittestconn = ConfigurationManager.ConnectionStrings["unittestconn"].ConnectionString;
        string liveconnstring = ConfigurationManager.ConnectionStrings["liveconn"].ConnectionString;
        
        [SetUp]
        public void Setup()
        {
            DBManager.SetConnectionString(liveconnstring, true);
        }

        private DataTable GetDataTable(string sql)
        {
            DataTable dt = new();
            DBManager.SetConnectionString(liveconnstring, false);
            dt = SQLUtility.GetDataTable(sql);
            DBManager.SetConnectionString(liveconnstring, false);
            return dt;
        }

        private int GetFirstColumnFirstRowValue(string sql)
        {
            int n = 0;
            DBManager.SetConnectionString(liveconnstring, false);
            n = SQLUtility.GetFirstColumnFirstRowValue(sql);
            DBManager.SetConnectionString(liveconnstring, false);
            return n;
        }

        [Test]
        [TestCase("Food Test: ", 50, "2010-01-01", "2014-01-01", "2015-01-01")]
        [TestCase("Food: ", 50, "2010-01-01", "2014-01-01", "2014-01-08")]
        public void InsertNewRecipe(string recipename, int calories, DateTime draftdate, DateTime publishdate, DateTime archivedate)
        {
            int usersid = GetFirstColumnFirstRowValue("select top 1 usersid from users");
            Assume.That(usersid > 0, "Can't run test, no users in DB");
            int cuisinetypeid = GetFirstColumnFirstRowValue("select top 1 cuisinetypeid from cuisinetype");
            Assume.That(cuisinetypeid > 0, "Can't run test, no cuisinetypes in DB");

            recipename += DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
            DataTable dtrecipe = GetDataTable("select * from recipe r where r.recipename = '" + recipename + "'");
            Assume.That(dtrecipe.Rows.Count == 0, "recipe with name " + recipename + " is already found in db. Cannot insert 2 recipes with the same name.");
            TestContext.WriteLine("Recipe " + recipename + " does not exist in Recipe DB");
            TestContext.WriteLine("Ensure that recipe " + recipename + " is added to DB.");

            bizRecipe recipe = new();
            recipe.UsersId = usersid;
            recipe.CuisineTypeId = cuisinetypeid;
            recipe.RecipeName = recipename;
            recipe.Calories = calories;
            recipe.DraftDate = draftdate;
            recipe.PublishDate = publishdate;
            recipe.ArchiveDate = archivedate;
            recipe.Save();

            int newid = recipe.RecipeId;
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
            TestContext.WriteLine("Record with recipe " + recipeid + recipename + " exists in db. (Does not have connection to cookbook).");
            TestContext.WriteLine("Ensure that app can delete " + recipeid);
            bizRecipe recipe = new();
            recipe.Load(recipeid);
            recipe.Delete();
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
            bizRecipe recipe = new();
            recipe.Load(recipeid);
            int loadedid = recipe.RecipeId;
            string recipename = recipe.RecipeName;
            Assert.IsTrue(loadedid == recipeid && recipename != "", loadedid + " <> " + recipeid + "RecipeName = " + recipename);
            TestContext.WriteLine("Loaded recipe (" + loadedid + ") RecipeName = " + recipename);
        }

        [Test]
        [TestCase("c")]
       
        public void SearchRecipe(string criteria)
        {
            int recipecount = GetFirstColumnFirstRowValue("select total = count(*) from recipe r where r.recipename like '%" + criteria + "%'");
            Assume.That(recipecount > 0, "There aren't any recipes that match the search for " + criteria);
            TestContext.WriteLine(recipecount + " recipes that match '" + criteria + "'.");
            TestContext.WriteLine("Ensure that recipe search returns " + recipecount + " rows");
            bizRecipe r = new();
            List<bizRecipe> lst = r.Search(criteria);
            Assert.IsTrue(lst.Count == recipecount, "Results of recipe search does not match number of recipes, " + lst.Count + " <> " + recipecount);
            TestContext.WriteLine("Number of rows returned by recipe search is " + lst.Count);
        }

        [Test]
        [TestCase("c")]

        public void SearchIngredient(string criteria)
        {
            int ingredientcount = GetFirstColumnFirstRowValue("select total = count(*) from ingredient i where i.ingredientname like '%" + criteria + "%'");
            Assume.That(ingredientcount > 0, "There aren't any ingredients that match the search for " + criteria);
            TestContext.WriteLine(ingredientcount + " ingredients that match '" + criteria + "'.");
            TestContext.WriteLine("Ensure that ingredient search returns " + ingredientcount + " rows");
            bizIngredient r = new();
            List<bizIngredient> lst = r.Search(criteria);
            Assert.IsTrue(lst.Count == ingredientcount, "Results of ingredient search does not match number of ingredient, " + lst.Count + " <> " + ingredientcount);
            TestContext.WriteLine("Number of rows returned by ingredient search is " + lst.Count);
        }

        [Test]
        public void GetListOfRecipes( )
        {
            int recipecount = GetFirstColumnFirstRowValue("select total = count(*) from recipe");
            Assume.That(recipecount > 0, "No recipes in DB, can't test");
            TestContext.WriteLine("Num of recipes in DB = " + recipecount);
            TestContext.WriteLine("Ensure that num of rows returned by app matches " + recipecount);
            bizRecipe r = new();
            var lst = r.GetList();
            Assert.IsTrue(lst.Count == recipecount, "Num rows returned by app (" + lst.Count + ") <> " + recipecount);
            TestContext.WriteLine("Number of Recipes returned by app = " + lst.Count);
        }

        [Test]
        [TestCase(false)]
        [TestCase(true)]
        public void GetListOfIngredients(bool includeblank)
        {
            int ingredientcount = GetFirstColumnFirstRowValue("select total = count(*) from ingredient");
            if (includeblank == true) { ingredientcount = ingredientcount + 1; }
            Assume.That(ingredientcount > 0, "No ingredients in DB, can't test");
            TestContext.WriteLine("Number of rows in DB = " + ingredientcount);
            TestContext.WriteLine("Ensure that num of rows returned by app matches " + ingredientcount);
            bizIngredient p = new();
            var lst = p.GetList(includeblank);

            Assert.IsTrue(lst.Count == ingredientcount, "Num rows returned by app (" + lst.Count + ") <> " + ingredientcount);
            TestContext.WriteLine("Number of Ingredients = " + lst.Count);
        }

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