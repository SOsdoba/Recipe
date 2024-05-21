using CPUFramework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RecipeAppSystem
{
    public class Meals
    {
        public static DataTable SearchMeals()
        {
            DataTable dt = new();

            SqlCommand cmd = SQLUtility.GetSQLCommand("MealGet");
            cmd.Parameters["@All"].Value = 1;

            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }
        public static DataTable Load(int mealid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("MealGet");
            SQLUtility.SetParamValue(cmd, "@Mealid", mealid);
            cmd.Parameters["@MealId"].Value = mealid;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }
    }
}
