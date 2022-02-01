using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavrhoveVzory1.Models
{
    public class Duchodce : Osoba
    {
        public Duchodce(int vek, Gender gender, string jmeno) : base(vek, gender, jmeno)
        {

        }
        public override string ToString()
        {
            return Jmeno + ", " + Vek + "let, " + Gender.ToString() + ", je Důchodce";
        }
    }
}
