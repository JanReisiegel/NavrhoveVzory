// See https://aka.ms/new-console-template for more information
using IPTV.Models;

Smerovac smerovac = Smerovac.NewSmerovac();
Prijimac p1 = new Prijimac(null);
Prijimac p2 = new Prijimac(null);
Vysilac v1 = Vysilac.NewVysilac(Guid.NewGuid().ToString(), TypVysilani.Nic);
smerovac.OdebiraniObsahu(p1, v1, TypVysilani.Zprávy);
smerovac.OdebiraniObsahu(p2, v1, TypVysilani.Sport);
smerovac.OdebiraniObsahu(p1, v1, TypVysilani.Filmy);
v1.Vysilani("Situace na Ukrajině se zhoršuje.", TypVysilani.Zprávy);
v1.Vysilani("Pouštím film: Black Widow", TypVysilani.Filmy);
v1.Vysilani("Ale ne! Šimon Hrubec dostal další gól. Švýcarsko vede na českou reprezentací 3:1.", TypVysilani.Zprávy);
