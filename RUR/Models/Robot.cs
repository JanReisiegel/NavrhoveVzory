using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUR.Models
{
    internal class Robot
    {
        private string _name;
        private Modul? _activeModul;
        public int Cas { get; set; }
        public string Name { get; }
        public Robot(string name, Modul? activeModul)
        {
            _name=name;
            _activeModul=activeModul;
        }

        public void ProvedCinnost(Povel povel)
        {
            _activeModul = Modul.GetModulInstance(povel.Cinnost);
            Console.WriteLine(povel.Cas);
            _activeModul.Pracuj(povel.Cas);
        }
        public string VypisCinnost()
        {
            return _activeModul.ToString();
        }
    }
}
