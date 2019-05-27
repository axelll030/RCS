using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D5
{
    class Aplis
    {
        //properties
        public int R;

        public string Krasa;

        //constructor
        public Aplis(int r, string krasa)
        {
            this.R = r;     //ja nosaukimi ir vienadi vr izmantot THIS lai versties pie mainiga vispirms
            Krasa = krasa;
        }

        //methods
        public double Perimetrs()
        {
            return 2 * Math.PI * R;
        }

        public double Laukums()
        {
            return R * R * Math.PI;
        }

        public string KrasasNosaukums()
        {
            return Krasa;
        }
    }
}
