using CPUFramework;
using System.Data;
using System.Data.SqlClient;

namespace RecipeAppSystem
{
    public class RecipeIngredientsandSteps
    {
        public static DataTable LoadByRecipeId(int recipeid, string sprocname)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand(sprocname);
            cmd.Parameters["@RecipeId"].Value = recipeid;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }
                                
        public static void SaveTable(DataTable dt, int recipeid, string sprocname)
        {
            //var lst = dt.Select("", "", DataViewRowState.Added | DataViewRowState.ModifiedCurrent);
            //foreach (DataRow r in lst)
            //{
            //    r["RecipeId"] = recipeid;
            //}
            //SQLUtility.SaveDataTable(dt, sprocname);

            foreach (DataRow r in dt.Select("", "", DataViewRowState.Added | DataViewRowState.ModifiedCurrent))
            {
                r["RecipeId"] = recipeid;
            }
            SQLUtility.SaveDataTable(dt, sprocname);
        }

        public static void Delete(int id, string sprocname, string paramname)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand(sprocname);
            cmd.Parameters[paramname].Value = id;
            SQLUtility.ExecuteSQL(cmd);
        }

    }
}
