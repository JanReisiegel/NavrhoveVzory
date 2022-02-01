using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavrhoveVzory1.Models
{
    public class Osoba
    {
        private readonly int _vek;
        private readonly Gender _gender;
        private readonly string _jmeno;

        public int Vek { get { return _vek; } }
        public Gender Gender { get { return _gender; } }
        public string Jmeno { get { return _jmeno; } }

        protected Osoba(int vek, Gender gender, string jmeno)
        {
            _vek=vek;
            _gender=gender;
            _jmeno=jmeno;
        }
        public static Osoba? GetInstance(int vek, int pohlavi, string jmeno)
        {
            Gender gender = pohlavi switch
            {
                0 => Gender.male,
                1 => Gender.female,
                2 => Gender.person,
                3 => Gender.other,
                _ => Gender.other
            };
            switch (vek)
            {
                case < 0:
                    return null;
                case <=7:
                    return Predskolak.NewPredskolak(vek, gender, jmeno);
                case <=19:
                    return Skolak.NewSkolak(vek, gender, jmeno);
                case <=65:
                    return Pracujici.NewPracujici(vek, gender, jmeno);
                case >65:
                    return new Duchodce(vek, gender, jmeno);
            }            
        }

    }
    public enum Gender
    {
        male = 0,
        female = 1,
        person = 2,
        other = 3
    }
}
