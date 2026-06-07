using System;
using System.Collections.Generic;
using System.Text;

namespace IksirDukkani.Core.Results
{
    public class Result:IResult
    {
        public bool BasariliMi { get; }
        public string Mesaj { get; }

        public Result(bool basariliMi, string mesaj)
        {
            BasariliMi = basariliMi;
            Mesaj = mesaj;
        }
        public Result(bool basariliMi)
        {
            BasariliMi = basariliMi;
            
        }

    }
}
