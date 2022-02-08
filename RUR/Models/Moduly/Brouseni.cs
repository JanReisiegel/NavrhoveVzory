using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUR.Models.Moduly
{
    public class Brouseni : Modul
    {
        private Brouseni(CinnostType type) : base(type)
        {

        }

        public static Brouseni NewBrouseni(CinnostType type)
        {
            return new Brouseni(type);
        }

        public override void Pracuj(int time)
        {
            Console.WriteLine("Brousím, čas: " + time);
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
