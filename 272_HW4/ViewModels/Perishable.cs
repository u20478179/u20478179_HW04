using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _272_HW4.ViewModels
{
    public class Perishable : Food
    {
        private bool _Dairy;
        private bool _FruitVeg;


        public Perishable(DateTime expiaryDate, string name, string mainIngrediant, bool dairy, bool fruitVeg) : base(expiaryDate, name, mainIngrediant)
        {

            _Dairy = dairy;
            _FruitVeg = fruitVeg;
        }



        public bool Dairy
        {
            get { return _Dairy; }
            set { _Dairy = value; }
        }

        public bool FruitVeg
        {
            get { return _FruitVeg; }
            set { _FruitVeg = value; }
        }

        public override string getinfo()
        {
            if(Dairy == true)
            {
                return "This is a dairy Product" + " and will exipre on " + ExpiaryDate;
            }
            else if (FruitVeg == true)
            {
                return "This is a Fruit or Vegatable" + " and will exipre on " + ExpiaryDate;
            }
            else
            {
                return "The " + Name + " is mostly made from " + MainIngrediant + " and will exipre on " + ExpiaryDate;
            }
                
                
        }

        public override string urgency()
        {
            if (Dairy == true)
            {
                return "Highly urgent to be used";
            }
            else if (FruitVeg == true)
            {
                return "Highly urgent to be used";
            }
            else if (ExpiaryDate.AddDays(-14) < DateTime.Now)
            {
                return "Highly urgent to be used";
            }
            else
            {
                return "Not urgent";
            }
        }
    }
}