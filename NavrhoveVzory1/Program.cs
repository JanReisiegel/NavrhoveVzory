// See https://aka.ms/new-console-template for more information
using NavrhoveVzory1.Models;
while (true)
{
    Console.WriteLine("Jméno: ");
    string jmeno = Console.ReadLine();
    Console.WriteLine("Věk: ");
    int vek = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Pohlaví: (0 = Muž; 1 = Žena; 2 = Osoba; 3 = Jiné) ");
    int pohlavi = Int32.Parse(Console.ReadLine());
    Osoba NovaOsoba = Osoba.GetInstance(vek, pohlavi, jmeno);
    Console.WriteLine(NovaOsoba.ToString());
}