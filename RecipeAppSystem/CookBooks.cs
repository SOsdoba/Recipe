using CPUFramework;
using System.Data.SqlClient;
using System.Data;

namespace RecipeAppSystem
{
    public class CookBooks
    {
        public static DataTable SearchCookBooks()
        {
            DataTable dt = new();

            SqlCommand cmd = SQLUtility.GetSQLCommand("CookBookGet");
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

        public static DataTable Load(int cookbookid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("CookBookGet");
            SQLUtility.SetParamValue(cmd, "@CookBookId", cookbookid);
            cmd.Parameters["@CookBookId"].Value = cookbookid;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }
        public static void Save(DataTable dtcookbook)
        {
            if (dtcookbook.Rows.Count == 0)
            {
                throw new Exception("Cannot call CookBook Save method because there are no rows in the table.");
            }
            DataRow r = dtcookbook.Rows[0];
            SQLUtility.SaveDataRow(r, "CookBookUpdate");
        }

        public static void Delete(DataTable dtcookbooks)
        {
            int id = (int)dtcookbooks.Rows[0]["CookBookId"];
            SqlCommand cmd = SQLUtility.GetSQLCommand("CookBookDelete");
            SQLUtility.SetParamValue(cmd, "@CookBookId", id);
            SQLUtility.ExecuteSQL(cmd);
        }

        public static int CloneCookBook(int usersid)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("CreateCookBook");
            SQLUtility.SetParamValue(cmd, "@UsersId", usersid);
            SQLUtility.ExecuteSQL(cmd);
            int newcookbookid = (int)cmd.Parameters["@CookBookId"].Value;
            return newcookbookid;
        }
        public static int NewCookBookIdGet()
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("NewCookBookIdGet");
            cmd.Parameters["@All"].Value = 1;
            DataTable dt = SQLUtility.GetDataTable(cmd);
            int cookbookid = Convert.ToInt16(dt.Rows[0][0]);
            return cookbookid;
        }
    }
}
