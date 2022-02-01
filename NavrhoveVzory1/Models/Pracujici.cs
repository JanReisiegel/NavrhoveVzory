using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavrhoveVzory1.Models
{
    internal class Pracujici : Osoba
    {
        public static List<Pracujici> vsichniPracujici = new List<Pracujici>();
        protected Pracujici(int vek, Gender gender, string jmeno) : base(vek, gender, jmeno)
        {

        }

        public static Pracujici NewPracujici(int vek, Gender gender, string jmeno)
        {
            var newPracujici = new Pracujici(vek, gender, jmeno);
            if (!vsichniPracujici.Contains(newPracujici))
                vsichniPracujici.Add(newPracujici);
            return newPracujici;
        }

        public override string ToString()
        {
            return Jmeno + ", " + Vek + "let, " + Gender.ToString() + ", je Školák";
        }
    }
}
