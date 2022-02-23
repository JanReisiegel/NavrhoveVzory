using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPTV.Models
{
    class Smerovac
    {
        private const int capacity = 30 ;
        public static Smerovac smerovac;
        private Dictionary<Prijimac, Vysilac> prijimace;
        private Queue<string> neprijateZpravy = new Queue<string>(capacity);
        private Smerovac()
        {
            prijimace = new List<Prijimac>();
        }

        public static Smerovac NewSmerovac()
        {
            if(smerovac == null)
                smerovac = new Smerovac();
            return smerovac;
        }

        public void OdebiraniObsahu(Prijimac prij, Vysilac vys, TypVysilani type)
        {
            if (prijimace.ContainsKey(prij))
            {
                return;
            }
            prijimace.Add(prij, vys);
        }

        public void OdodebiraniObsahu(Prijimac prij)
        {
            prijimace.Remove(prij);
        }

        public void Prenos(Zprava msg)
        {
            bool doruceno = false;
            foreach(var i in prijimace)
            {
                Vysilac vys = Vysilac.NewVysilac(msg.vysilacId, msg.type);
                if (i.Value.Equals(vys))
                {
                    i.Key.
                }
            }
        }

    }
}
