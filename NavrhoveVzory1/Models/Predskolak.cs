using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavrhoveVzory1.Models
{
    class Predskolak : Osoba
    {
        public static Predskolak predskolak;
        private Predskolak(int vek, Gender gender, string jmeno) : base(vek, gender, jmeno)
        {

        }
        public static Predskolak NewPredskolak(int vek, Gender gender, string jmeno)
        {
            if (predskolak == null)
            {
                predskolak = new Predskolak(vek, gender, jmeno);
            }
            return predskolak;
        }
        public override string ToString()
        {
            return Jmeno + ", " + Vek + "let, " + Gender.ToString() + ", je Předškolák";
        }
    }
}
