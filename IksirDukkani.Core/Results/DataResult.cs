using System;
using System.Collections.Generic;
using System.Text;

namespace IksirDukkani.Core.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public T Veri { get; }
        public DataResult(T veri, bool basariliMi, string mesaj) : base(basariliMi, mesaj)
        {
            Veri = veri;
        }
        public DataResult(T veri, bool basariliMi) : base(basariliMi)
        {
            Veri = veri;
        }
        
        
    
    }
}
