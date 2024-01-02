using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using CPUFramework;

namespace RecipeAppSystem
{
    public class Recipe
    {
        public static DataTable SearchRecipes(string recipename)
        {
            DataTable dt = new();

            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeGet");

            if (recipename == "")
            {
                cmd.Parameters["@All"].Value = 1;
            }

            cmd.Parameters["@RecipeName"].Value = recipename;

            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable Load(int recipeid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeGet");
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

        public static DataTable GetUsersList()
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("UsersGet");
            cmd.Parameters["@All"].Value = 1;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static void Save(DataTable dtrecipes)
        {
            if(dtrecipes.Rows.Count == 0)
            {
                throw new Exception("Cannot call Recipe Save method because there are no rows in the table.");
            }
            DataRow r = dtrecipes.Rows[0];
            
            SQLUtility.SaveDataRow(r, "RecipeUpdate");
        }

        public static void Delete(DataTable dtrecipes)
        {
            int id = (int)dtrecipes.Rows[0]["RecipeId"];
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeDelete");
            SQLUtility.SetParamValue(cmd, "@RecipeId", id);
            //string sql = "delete recipe where RecipeId = " + id;
           SQLUtility.ExecuteSQL(cmd);
        }
    }
}
