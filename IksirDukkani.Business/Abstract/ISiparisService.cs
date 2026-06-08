using IksirDukkani.Core.Results;
using IksirDukkani.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IksirDukkani.Business.Abstract
{
    public interface ISiparisService
    {
        IResult SiparisKontrolEt(Iksir istenenIksir, string oyuncuGirdisi);

    }
}
