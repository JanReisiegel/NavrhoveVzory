using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPTV.Models
{
    internal class Zprava
    {
        public readonly string vysilacId;
        public readonly TypVysilani type;
        public readonly string text;

        public Zprava(string vId, TypVysilani t, string txt)
        {
            vysilacId=vId;
            type=t;
            text=txt;
        }
    }
}
