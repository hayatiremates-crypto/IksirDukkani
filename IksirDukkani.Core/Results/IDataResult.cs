using System;
using System.Collections.Generic;
using System.Text;

namespace IksirDukkani.Core.Results
{
    public interface IDataResult<T> : IResult
    {
        T Veri { get; }
    }
}
