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
            if (Robots == null)
            {
                Robots = new List<Robot>();
            }
            var newRobor = new Robot(name, null);
            Robots.Add(newRobor);
            return newRobor;
        }

        public static void PredejPovel(int posRobot, int posPovel)
        {
            var cinPovel = posPovel switch
            {
                1 => CinnostType.brouseni,
                2 => CinnostType.rezani,
                3 => CinnostType.svarovani,
                4 => CinnostType.vrtani,
                _ => CinnostType.defaultpos
            };
        }
    }
}
