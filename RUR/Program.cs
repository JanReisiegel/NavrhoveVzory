// See https://aka.ms/new-console-template for more information
using RUR.Models;
Ovladac ovladac = new Ovladac();
ovladac.AddNewRobot("Robot1");
ovladac.AddNewRobot("Robot2");
ovladac.PridejPovel(1, 5, "tovarna1");
ovladac.PridejPovel(2, 5, "tovarna1");
ovladac.PridejPovel(3, 5, "tovarna1");
ovladac.PridejPovel(4, 5, "tovarna1");
ovladac.PredejPovel(1, CinnostType.brouseni, 10, "pole123");
Console.WriteLine("----------");
ovladac.PredejPovel(1, CinnostType.vrtani, 5, "pole2");
Console.WriteLine("----------");
