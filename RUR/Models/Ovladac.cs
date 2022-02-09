using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUR.Models
{
    internal class Ovladac
    {
        public Robot? AddNewRobot(string name)
        {
            return Robot.NewRobot(name);
        }

        public void PredejPovel(int posRobot, CinnostType cinnost, int cas, string misto)
        {
            if(posRobot > Robot.Robots.Count - 1)
            {
                Console.WriteLine("---------- \nZadaná pozice robota neodpovídá žádnému robotovi. \n ----------");
                return;
            }
            var robot = Robot.Robots[posRobot - 1];
            robot.ProvedCinnost(Povel.NewPovel(cinnost, cas, misto));
        }

        public void PridejPovel(int type, int cas, string misto)
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
