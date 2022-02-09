using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUR.Models
{
    class Povel
    {
        private readonly CinnostType _cinnost;
        private readonly int _cas;
        private readonly string _misto;
        public CinnostType Cinnost { get { return _cinnost; } }
        public int Cas { get { return _cas; } }
        //public static List<Povel> Povels { get; private set; } = new List<Povel>();

        private Povel(CinnostType cinnost, int cas, string misto)
        {
            _cinnost = cinnost;
            _cas = cas;
            _misto = misto;
        }

        public static Povel NewPovel(CinnostType type, int cas, string misto)
        {
            Povel newPovel = new Povel(type, cas, misto);
            return newPovel;
        }
    }
    public enum CinnostType
    {
        vrtani,
        brouseni,
        svarovani,
        rezani,
        defaultpos
    }
}
