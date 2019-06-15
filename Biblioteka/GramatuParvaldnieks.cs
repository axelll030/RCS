using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class GramatuParvaldnieks
    {
        public List<Gramata> Gramatas;

        public GramatuParvaldnieks()
        {
            Gramatas.Add(new Gramata() { Nosaukums = "The Illiad", Skaits = 1 });
            Gramatas.Add(new Gramata() { Nosaukums = "The Inferno", Skaits = 1 });
        }

        public Gramata PanemtGramatu(string nosaukums)
        {
            //1.parbauda vai saraksta ir gramataar sadu nosaukumu
            //ja nav tad izveidot pazinojumu
            //2.Parbaudu vai gramatu skaits>0
        }

        public void AtgrieztGramatu(string nosaukums)
        {

        }
    }
}
