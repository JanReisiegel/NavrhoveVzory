using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavrhoveVzory1.Models
{
    internal class Skolak : Osoba
    {
        public static Skolak[] skolaci;
        protected Skolak(int vek, Gender gender, string jmeno) : base(vek, gender, jmeno)
        {

        }
        public static Skolak? NewSkolak(int vek, Gender gender, string jmeno)
        {
            var newSkolak = new Skolak(vek, gender, jmeno);
            if (skolaci == null)
            {
                skolaci = new Skolak[30];
            }
            if (skolaci.Contains(null))
            {
                
                for (int a = 0; a < skolaci.Count(); a++)
                {
                    if(skolaci[a] == null)
                    {
                        skolaci[a] = newSkolak;
                        return newSkolak;
                    }
                }
            }
            return null;
        }

        public override string ToString()
        {
            return Jmeno + ", " + Vek + "let, " + Gender.ToString() + ", je Školák";
        }
    }
}
