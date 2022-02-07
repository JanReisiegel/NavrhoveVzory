using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUR.Models.Moduly
{
    public class Rezani : Modul
    {
        private Rezani(CinnostType type) : base(type)
        {

        }

        public static Rezani NewRezani(CinnostType type)
        {
            return new Rezani(type);
        }

        public override void Pracuj(int time)
        {
            Console.WriteLine("Řežu, čas: " + time);
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
