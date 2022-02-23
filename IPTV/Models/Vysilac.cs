using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPTV.Models
{
    class Vysilac
    {
        public string _idVysilace;
        public TypVysilani typVysilani;
        public Smerovac smerovac;
        public static List<Vysilac> vysilace = new List<Vysilac>();

        private Vysilac(string id_vysilace, Smerovac sm, TypVysilani tVysilani)
        {
            smerovac=sm;
            typVysilani=tVysilani;
            _idVysilace=id_vysilace;
        }

        public static Vysilac NewVysilac(string idVysilace, TypVysilani type)
        {
            Vysilac newVysilac = new Vysilac(idVysilace, Smerovac.smerovac, type);
            if (!vysilace.Contains(newVysilac))
            {
                vysilace.Add(newVysilac);
            }
            return newVysilac;
        }
    }
}
