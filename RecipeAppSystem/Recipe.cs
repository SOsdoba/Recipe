using System.Data;
using System.Data.SqlClient;
using CPUFramework;

namespace RecipeAppSystem
{
    public class Recipe
    {
        public static DataTable SearchRecipes()
        {
            DataTable dt = new();

            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeListGet");
            cmd.Parameters["@All"].Value = 1;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable Load(int recipeid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeGet");
            SQLUtility.SetParamValue(cmd, "@Recipeid", recipeid);
            cmd.Parameters["@RecipeId"].Value = recipeid;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable GetCuisineList()
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("CuisineTypeGet");
            cmd.Parameters["@All"].Value = 1;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable GetUsersList( int includeblank)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("UsersGet");
            if(includeblank == 1)
            {
                cmd.Parameters["@IncludeBlank"].Value = 1;
            }
            cmd.Parameters["@All"].Value = 1;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static void Save(DataTable dtrecipe)
        {
            if(dtrecipe.Rows.Count == 0)
            {
                throw new Exception("Cannot call Recipe Save method because there are no rows in the table.");
            }
            DataRow r = dtrecipe.Rows[0];
            SQLUtility.SaveDataRow(r, "RecipeUpdate");
        }

        public static void Delete(DataTable dtrecipes)
        {
            int id = (int)dtrecipes.Rows[0]["RecipeId"];
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeDelete");
            SQLUtility.SetParamValue(cmd, "@RecipeId", id);
            SQLUtility.ExecuteSQL(cmd);
        }

        public static void CloneRecipe(int baserecipeid)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("CloneRecipe");
            SQLUtility.SetParamValue(cmd, "@BaseRecipeId", baserecipeid);
            SQLUtility.ExecuteSQL(cmd);
        }

        public static int NewRecipeIdGet()
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("NewRecipeIdGet");
            cmd.Parameters["@All"].Value = 1;
            DataTable dt = SQLUtility.GetDataTable(cmd);
            int recipeid = Convert.ToInt16(dt.Rows[0][0]) ;
            return recipeid;
        }
    }
}