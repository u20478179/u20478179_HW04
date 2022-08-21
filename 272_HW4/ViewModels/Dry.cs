using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _272_HW4.ViewModels
{
    public class Dry : Food
    {
        private string _Grain;
        private bool _Cereal;


        public Dry(DateTime expiaryDate, string name, string mainIngrediant, string grain, bool cereal) : base(expiaryDate, name, mainIngrediant)
        {

            _Grain = grain;
            _Cereal = cereal;
        }



        public string Grain
        {
            get { return _Grain; }
            set { _Grain = value; }
        }

        public bool Cerealg
        {
            get { return _Cereal; }
            set { _Cereal = value; }
        }

        public override string getinfo()
        {
            return "The " + Name + " is mostly made from " + MainIngrediant + " and will exipre on " + ExpiaryDate;
        }

        public override string urgency()
        {
            return "Not urgent to be used until mixed with water, oil or milk";
        }
    }
}