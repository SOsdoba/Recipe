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
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeGet");
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

        public static int CloneRecipe(int baserecipeid)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("CloneRecipe");
            SQLUtility.SetParamValue(cmd, "@BaseRecipeId", baserecipeid); 
            SQLUtility.ExecuteSQL(cmd);
            int newrecipeid = (int)cmd.Parameters["@RecipeId"].Value;
            return newrecipeid;
        }

        public static void Delete(DataTable dtrecipes)
        {
            int id = (int)dtrecipes.Rows[0]["RecipeId"];
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeDelete");
            SQLUtility.SetParamValue(cmd, "@RecipeId", id);
            SQLUtility.ExecuteSQL(cmd);
        }
    }
}