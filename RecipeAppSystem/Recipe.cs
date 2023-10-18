using System.Data;
using System.Diagnostics;
using CPUFramework;

namespace RecipeAppSystem
{
    public class Recipe
    {
        public static DataTable SearchRecipes(string recipename)
        {
            string sqlstatement = "select RecipeId, RecipeName from recipe r where r.recipename like '%" + recipename + "%' ";
            DataTable dt = SQLUtility.GetDataTable(sqlstatement);
            return dt;
        }

        public static DataTable Load(int recipeid)
        {
            string sql = "select r.*, c.cuisinetype, u.username from recipe r join cuisinetype c on c.cuisinetypeid = r.cuisinetypeid join users u on u.usersid = r.usersid where r.recipeid = " + recipeid.ToString();
            return SQLUtility.GetDataTable(sql);
        }

        public static DataTable GetCuisineList()
        {
            return SQLUtility.GetDataTable("select CuisineTypeId, CuisineType from CuisineType");
        }

        public static DataTable GetUsersList()
        {
            return SQLUtility.GetDataTable("select UsersId, UserName from Users");
        }

        public static void Save(DataTable dtrecipes)
        {
            DataRow r = dtrecipes.Rows[0];
            string sql = "";
            int id = (int)r["RecipeId"];

            //draftdate = draftdate != "" ? "'" + r["DraftDate"] + "'" : "'" + DateTime.Now.ToString() + "'";
            //publishdate = publishdate != "" ? "'" + r["PublishDate"] + "'" : "null";
            //archivedate = archivedate != "" ? "'" + r["ArchiveDate"] + "'" : "null";
            //var draftDateValue = String.IsNullOrEmpty(r["DraftDate"].ToString()) ? "'" + DateTime.Now.ToString() + "'": "'" + r["DraftDate"].ToString() + "'";
            //var publishDateValue = String.IsNullOrEmpty(r["PublishDate"].ToString()) ? "null" : "'" + r["PublishDate"].ToString() + "'";
            //var archiveDateValue = String.IsNullOrEmpty(r["ArchiveDate"].ToString()) ? "null" : "'" + r["ArchiveDate"].ToString() + "'";

            if (id > 0)
            {
                sql = string.Join(Environment.NewLine, $"update Recipe set",
                $"UsersId = {r["UsersId"]} ,",
                $"CuisineTypeId = {r["CuisineTypeId"]} ,",
                $"RecipeName = '{r["RecipeName"]} ',",
                $"Calories = {r["Calories"]} ,",
                $"DraftDate = {r["DraftDate"]} ,",
                $"PublishDate = {r["PublishDate"]} ,",
                $"ArchiveDate = {r["ArchiveDate"]} ",
                $"where RecipeId = {r["RecipeId"]}");
            }
            else
            {
                sql = "insert recipe (UsersId, CuisineTypeId, RecipeName, Calories, DraftDate, PublishDate, ArchiveDate)";
                sql += $"select '{r["UsersId"]}', '{r["CuisineTypeId"]}', '{r["RecipeName"]}', {r["Calories"]}, '{r["DraftDate"]}' , '{r["PublishDate"]}' , '{r["ArchiveDate"]}' ";
            }

            Debug.Print("---------");
            SQLUtility.ExecuteSQL(sql);
        }

        public static void Delete(DataTable dtrecipes)
        {
            int id = (int)dtrecipes.Rows[0]["RecipeId"];
            string sql = "delete recipe where RecipeId = " + id;
            SQLUtility.ExecuteSQL(sql);
        }
    }
}
