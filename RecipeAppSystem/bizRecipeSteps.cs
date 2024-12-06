using CPUFramework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeAppSystem
{
    public class bizRecipeSteps : bizObject<bizRecipeSteps>
    {
        public bizRecipeSteps() { }
         
        public int _recipeid;
        public string _direction;

        public List<bizRecipeSteps> LoadByRecipeId(int recipeid)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeStepsGet");
            cmd.Parameters["@RecipeId"].Value = recipeid;
            var dt = SQLUtility.GetDataTable(cmd);
            return this.GetListFromDataTable(dt);
        }

        public int RecipeId
        {
            get { return _recipeid; }
            set
            {
                if(_recipeid != value)
                {
                    _recipeid = value;
                    InvokePropertyChanged();
                }
            }
        }
        public string Direction
        {
            get { return _direction; }
            set
            {
                if (_direction != value)
                {
                    _direction = value;
                    InvokePropertyChanged();
                }
            }
        }

    }
}
