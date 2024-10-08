using CPUFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeAppSystem
{
    public class bizCookbook :bizObject<bizCookbook>
    {
        public bizCookbook() { }

        private int _cookbookid;
        private int _usersid;
        private string _cookbookname;
        private decimal _price;
        private bool _cookbookactive;
        private DateTime _datebookcreated;
        private string _cookbookpicture;
        private string _cookbookskilldesc;

        public int CookBookId
        {
            get { return _cookbookid; }
            set
            {
                if (_cookbookid != value)
                {
                    _cookbookid = value;
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

        public string CookBookName
        {
            get { return _cookbookname; }
            set
            {
                if (_cookbookname != value)
                {
                    _cookbookname = value;
                    InvokePropertyChanged();
                }
            }
        }

        public decimal Price
        {
            get { return _price; }
            set
            {
                if (_price != value)
                {
                    _price = value;
                    InvokePropertyChanged();
                }
            }
        }

        public bool CookBookActive
        {
            get { return _cookbookactive; }
            set
            {
                if (_cookbookactive != value)
                {
                    _cookbookactive = value;
                    InvokePropertyChanged();
                }
            }
        }

        public DateTime DateBookCreated
        {
            get { return _datebookcreated; }
            set
            {
                if (_datebookcreated != value)
                {
                    _datebookcreated = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string CookBookPicture
        {
            get { return _cookbookpicture; }
            set
            {
                if (_cookbookpicture != value)
                {
                    _cookbookpicture = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string CookbookSkillDesc
        {
            get { return _cookbookskilldesc; }
            set
            {
                if (_cookbookskilldesc != value)
                {
                    _cookbookskilldesc = value;
                    InvokePropertyChanged();
                }
            }
        }

    }
}
