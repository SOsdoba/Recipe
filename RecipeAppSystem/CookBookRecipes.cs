using CPUFramework;
using System.Data.SqlClient;
using System.Data;

namespace RecipeAppSystem
{
    public class CookBook_Recipes
    {
        public static DataTable LoadByCookBookId(int cookbookid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("CookBookRecipesGet");
            cmd.Parameters["@CookBookId"].Value = cookbookid;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }
        public static void SaveTable(DataTable dt, int cookbookid, string sprocname)
        {
            //var lst = dt.Select("", "", DataViewRowState.Added | DataViewRowState.ModifiedCurrent);
            //foreach (DataRow r in lst)
            //{
            //    r["RecipeId"] = recipeid;
            //}
            //SQLUtility.SaveDataTable(dt, sprocname);

            foreach (DataRow r in dt.Select("", "", DataViewRowState.Added | DataViewRowState.ModifiedCurrent))
            {
                r["CookBookId"] = cookbookid;
            }
            SQLUtility.SaveDataTable(dt, sprocname);
        }

        public static void Delete(int id)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("CookBookRecipesDelete");
            cmd.Parameters["@CookBookRecipesId"].Value = id;
            SQLUtility.ExecuteSQL(cmd);
        }
    }
}
