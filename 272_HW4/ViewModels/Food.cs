using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _272_HW4.ViewModels
{
    public abstract class Food
    {
        private DateTime _ExpiaryDate;
        private string _Name;
        private string _MainIngrediant;

        public Food(DateTime expiaryDate, string name, string mainIngrediant)
        {
            _ExpiaryDate = expiaryDate;
            _Name = name;
            _MainIngrediant = mainIngrediant;
        }

        public DateTime ExpiaryDate
        {
            get { return _ExpiaryDate; }
            set { _ExpiaryDate = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public string MainIngrediant
        {
            get { return _MainIngrediant; }
            set { _MainIngrediant = value; }
        }

        public virtual string getinfo()//method
        {
            return "The " + Name + " is mostly made from " + MainIngrediant + " and will exipre on " + ExpiaryDate;
        }

        public abstract string urgency();
    }
}