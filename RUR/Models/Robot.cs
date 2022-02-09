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
        public static List<Robot> Robots { get; set; } = new List<Robot>();
        private Robot(string name, Modul? activeModul, int cas)
        {
            _name=name;
            _activeModul=activeModul;
            Cas=cas;
        }

        public static Robot NewRobot(string name)
        {
            var newRobot = new Robot(name, null, 0);
            Robots.Add(newRobot);
            return newRobot;
        }

        public void ProvedCinnost(Povel povel)
        {
            
            if((_activeModul != null) && (povel.Cinnost != _activeModul.Type))
            {
                RemoveModul();
            }
            AddModul(povel.Cinnost);
            if(_activeModul == null)
            {
                Console.WriteLine("Povel nemůže být proveden. Robotu se nepovedlo nasadit příslušný modul.");
                return;
            }
            _activeModul.Pracuj(povel.Cas);
        }

        private void RemoveModul()
        {

            Console.WriteLine($"Odebírám modul pro {_activeModul.Type.ToString()}");
            _activeModul = null;
        }

        private void AddModul(CinnostType cinnost)
        {
            _activeModul = Modul.GetModulInstance(cinnost);
            Console.WriteLine($"Nastavil jsem modul pro {cinnost}");
        }

        public string VypisCinnost()
        {
            return _activeModul.ToString();
        }
    }
}
