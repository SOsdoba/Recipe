using CPUFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeAppSystem
{
    public class bizRecipe : bizObject<bizRecipe>
    {
        public bizRecipe() { }

        private int _recipeid;
        private int _usersid;
        private int _cuisinetypeid;
        private string _recipename;
        private int _calories;
        private DateTime _draftdate;
        private DateTime _publishdate;
        private DateTime _archivedate;
        private string _recipestatus;
        private string _vegan;
        private string _username;
        private int _numingredients;

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

        public int UsersId
        {
            get { return _usersid; }
            set
            {
                if (_usersid != value)
                {
                    _usersid = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int CuisineTypeId
        {
            get { return _cuisinetypeid; }
            set
            {
                if (_cuisinetypeid != value)
                {
                    _cuisinetypeid = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string RecipeName
        {
            get { return _recipename; }
            set
            {
                if (_recipename != value)
                {
                    _recipename = value;
                    InvokePropertyChanged();
                }
            }
        }
        public int Calories
        {
            get { return _calories; }
            set
            {
                if (_calories != value)
                {
                    _calories = value;
                    InvokePropertyChanged();
                }
            }
        }

        public DateTime DraftDate
        {
            get { return _draftdate; }
            set
            {
                if (_draftdate != value)
                {
                    _draftdate = value;
                    InvokePropertyChanged();
                }
            }
        }

        public DateTime PublishDate
        {
            get { return _publishdate; }
            set
            {
                if (_publishdate != value)
                {
                    _publishdate = value;
                    InvokePropertyChanged();
                }
            }
        }

        public DateTime ArchiveDate
        {
            get { return _archivedate; }
            set
            {
                if (_archivedate != value)
                {
                    _archivedate = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string RecipeStatus
        {
            get { return _recipestatus; }
            set
            {
                if (_recipestatus != value)
                {
                    _recipestatus = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string Vegan
        {
            get { return _vegan; }
            set
            {
                if (_vegan != value)
                {
                    _vegan = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string UserName
        {
            get { return _username; }
            set
            {
                if (_username != value)
                {
                    _username = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int NumIngredients
        {
            get { return _numingredients; }
            set
            {
                if (_numingredients != value)
                {
                    _numingredients = value;
                    InvokePropertyChanged();
                }
            }
        }
    }
}
