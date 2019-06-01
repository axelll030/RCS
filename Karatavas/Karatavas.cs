using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karatavas
{
    class Karatavas
    {
        private string MinamaisVards { get; set; }
        private string AtminetaisVards { get; set; }
        private string[] VardiArray { get; set; }

    public Karatavas()
        {
            VardiArray = new[]
            {
                "ZILS",
                "SARKANS",
                "BRUNS"
            };
        }

        public void SaktSpeli()
        {
            Random rand = new Random();
            MinamaisVards = VardiArray[rand.Next(VardiArray.Length)];
            AtminetaisVards = new string[MinamaisVards.Length];
            for (int i = 0; i < AtminetaisVards.Length; i++)
            {
                AtminetaisVards[i] = "-";
            }
        }
    }
}
