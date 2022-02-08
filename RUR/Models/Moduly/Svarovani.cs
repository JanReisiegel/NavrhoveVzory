using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUR.Models.Moduly
{
    public class Svarovani : Modul
    {
        private Svarovani(CinnostType type) : base(type)
        {

        }
        public static Svarovani NewSvarovani(CinnostType type)
        {
            return new Svarovani(type);
        }
        public override void Pracuj(int time)
        {
            Console.WriteLine("Svářím, čas: " + time);
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
