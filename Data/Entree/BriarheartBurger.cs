using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entree
{
    public class BriarheartBurger
    {

        public double Price => 6.32;

        public uint Calories => 732;

        private bool ketchup;
        public bool Ketchup
        {
            get
            {
                return ketchup;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold ketchup");
                else specialInstructions.Remove("Hold ketchup");
                ketchup = value;
            }
        }

        public bool Bun { get; set; } = true;

        private bool mustartd = true;
        
        public bool Mustard
        {
            get => Mustard;
            set => Mustard = value;
        }


        private List<string> specialInstructions = new List<string>();
        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }

    }
}
