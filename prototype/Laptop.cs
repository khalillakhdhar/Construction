using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction.prototype
{
    public class Laptop : Personal
    {
        public float autonomie;

        public Laptop(float autonomie)
        {
            this.autonomie = autonomie;
        }
        public void Clonage(Personal cp,float autonomie)
        {

            this.carteGraphique = cp.carteGraphique;
            this.CPU = cp.CPU;
            this.autonomie = autonomie;
        }
    }
}
