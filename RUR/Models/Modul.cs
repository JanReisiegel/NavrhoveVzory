using RUR.Models.Moduly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUR.Models
{
    public class Modul
    {
        private CinnostType _type;
        public CinnostType Type { get { return _type; } }
        public Modul(CinnostType type)
        {
            _type = type;
        }

        public static Modul? GetModulInstance(CinnostType cType)
        {
            switch (cType)
            {
                case CinnostType.vrtani:
                    return Vrtani.NewVrtani(cType);
                case CinnostType.brouseni:
                    return Brouseni.NewBrouseni(cType);
                case CinnostType.rezani:
                    return Rezani.NewRezani(cType);
                case CinnostType.svarovani:
                    return Svarovani.NewSvarovani(cType);
                default: return null;
            }
        }

        public virtual void Pracuj(int time)
        {
            Console.WriteLine("Nedělám nic, čas: " + time);
        }
    }
}
