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

        public Robot(string name, Modul? activeModul)
        {
            _name=name;
            _activeModul=activeModul;
        }

        public void ProvedCinnost(Povel povel)
        {

        }
        public string VypisCinnost()
        {
            return _activeModul.ToString();
        }
    }
}
