using CPUFramework;
using System.Data;
using System.Data.SqlClient;

namespace RecipeAppSystem
{
    public static class DataMaintenance
    {
        public static DataTable GetDataList(string tablename, int includeblank)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand(tablename + "Get");
            SQLUtility.SetParamValue(cmd, "@All", 1);
            if(includeblank == 1)
            {
                SQLUtility.SetParamValue(cmd, "@IncludeBlank", 1);
            }
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static void SaveDataList(DataTable dt, string tablename)
        {
            SQLUtility.SaveDataTable(dt, tablename + "Update");
        }

        public static DataTable GetDashboard()
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("DashboardGet");
            return SQLUtility.GetDataTable(cmd);            
        }
        
        public static void DeleteRow(string tablename, int id)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand(tablename + "Delete");
            if(tablename == "CourseType")
            {
                tablename = "Course";
            }
            SQLUtility.SetParamValue(cmd, $"@{tablename}Id", id);
            SQLUtility.ExecuteSQL(cmd);
        }
    }
}