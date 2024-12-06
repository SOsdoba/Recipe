using CPUFramework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeAppSystem
{
    public class bizRecipeIngredients :bizObject<bizRecipeIngredients>
    {
        public bizRecipeIngredients() { }

        private int _recipeingredientid;
        public string _ingredientname;
        private int _ingredientsequence;

        public List<bizRecipeIngredients> LoadByRecipeId(int recipeid)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeIngredientGet");
            cmd.Parameters["@RecipeId"].Value = recipeid;
            var dt = SQLUtility.GetDataTable(cmd);
            return this.GetListFromDataTable(dt);
        }



        private int RecipeIngredientId
        {
            get { return _recipeingredientid; }
            set
            {
                if(_recipeingredientid != value)
                {
                    _recipeingredientid = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string IngredientName
        {
            get { return _ingredientname; ; }
            set
            {
                if (_ingredientname != value)
                {
                    _ingredientname = value;
                    InvokePropertyChanged();
                }
            }
        }


        private int IngredientSequence
        {
            get { return _ingredientsequence; }
            set
            {
                if (_ingredientsequence != value)
                {
                    _ingredientsequence = value;
                    InvokePropertyChanged();
                }
            }
        }


    }
}
