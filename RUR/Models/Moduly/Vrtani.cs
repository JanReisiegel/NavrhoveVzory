using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUR.Models.Moduly
{
    public class Vrtani : Modul
    {
        private Vrtani(CinnostType type) : base(type)
        {

        }

        public static Vrtani NewVrtani(CinnostType type)
        {
            return new Vrtani(type);
        }

        public override void Pracuj(int time)
        {
            Console.WriteLine("Vrtám, čas: " + time);
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
