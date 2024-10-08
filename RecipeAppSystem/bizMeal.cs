using CPUFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeAppSystem
{
    public class bizMeal :bizObject<bizMeal>
    {
        public bizMeal() { }

        private int _mealid;
        private int _usersid;
        private string _mealname;
        private bool _mealactive;
        private DateTime _datemealcreated;
        private string _mealpicture;
        private string _mealdesc;

        public int MealId
        {
            get { return _mealid; }
            set
            {
                if (_mealid != value)
                {
                    _mealid = value;
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

        public string MealName
        {
            get { return _mealname; }
            set
            {
                if (_mealname != value)
                {
                    _mealname = value;
                    InvokePropertyChanged();
                }
            }
        }

        public bool MealActive
        {
            get { return _mealactive; }
            set
            {
                if (_mealactive != value)
                {
                    _mealactive = value;
                    InvokePropertyChanged();
                }
            }
        }

        public DateTime DateMealCreated
        {
            get { return _datemealcreated; }
            set
            {
                if (_datemealcreated != value)
                {
                    _datemealcreated = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string MealPicture
        {
            get { return _mealpicture; }
            set
            {
                if (_mealpicture != value)
                {
                    _mealpicture = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string MealDesc
        {
            get { return _mealdesc; }
            set
            {
                if (_mealdesc != value)
                {
                    _mealdesc = value;
                    InvokePropertyChanged();
                }
            }
        }

    }
}
