using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUR.Models
{
    internal class Ovladac
    {
        public static List<Robot> Robots { get; set; } = new List<Robot>();
        public static Robot? AddNewRobot(string name)
        {
            var newRobor = new Robot(name, null);
            if(Robots.Where(x=>x.Name == name).Any())
                return newRobor;
            Robots.Add(newRobor);
            return newRobor;
        }

        public static void PredejPovel(int posRobot, int posPovel)
        {
            if(posRobot > Robots.Count - 1)
            {
                Console.WriteLine("---------- \nZadaná pozice robota neodpovídá žádnému robotovi. \n ----------");
                return;
            }
            var robot = Robots[posRobot - 1];
            robot.ProvedCinnost(Povel.Povels[posPovel - 1]);
        }

        public static void PridejPovel(int type, int cas, string misto)
        {
            var cinPovel = type switch
            {
                1 => CinnostType.brouseni,
                2 => CinnostType.rezani,
                3 => CinnostType.svarovani,
                4 => CinnostType.vrtani,
                _ => CinnostType.defaultpos
            };
            Povel.NewPovel(cinPovel, cas, misto);
            
        }
    }
}
