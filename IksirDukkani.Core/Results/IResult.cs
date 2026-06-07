using System;
using System.Collections.Generic;
using System.Text;

namespace IksirDukkani.Core.Results
{
    public interface IResult
    {
        bool BasariliMi { get; }
        string Mesaj { get; }
    }
}
