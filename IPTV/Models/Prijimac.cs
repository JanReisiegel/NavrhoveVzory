using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPTV.Models
{
    internal class Prijimac
    {
        public string? vysilacId;
        

        public Prijimac(string? vId)
        {
            vysilacId=vId;
            
        }

        public bool PrijemVysilani (Zprava msg)
        {
            Console.WriteLine($"Zpráva \"{msg.text}\" byla přijata ");
            return true;
        }
    }
}
