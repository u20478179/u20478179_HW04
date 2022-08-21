using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _272_HW4.ViewModels
{
    public class Canned : Food
    {
        private int _Quantity;
        private string _Size;


        public Canned(DateTime expiaryDate, string name, string mainIngrediant, int quantity, string size) : base(expiaryDate, name, mainIngrediant)
        {

            _Quantity = quantity;
            _Size = size;
        }



        public int Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }
        public string Size
        {
            get { return _Size; }
            set { _Size = value; }
        }

        public override string getinfo()
        {
            return "The " + Name + " is mostly made from " + MainIngrediant + " and will exipre on " + ExpiaryDate;
        }

        public override string urgency()
        {
            return "Very long lasting, not urgert to be eaten";
        }
    }
}