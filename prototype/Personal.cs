using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction.prototype
{
   public  class Personal
    {
        public string CPU;
        public string Marque;
        public int RAM;
        public string carteGraphique;

        public Personal(string cPU, string marque, int rAM, string carteGraphique)
        {
            CPU = cPU;
            Marque = marque;
            RAM = rAM;
            this.carteGraphique = carteGraphique;
        }

        public Personal()
        {
        }

        public Personal Clone()
        {
            return this;
        }

    }
}
