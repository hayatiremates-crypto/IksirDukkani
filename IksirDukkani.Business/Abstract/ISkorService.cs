using IksirDukkani.Core.Results;
using IksirDukkani.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IksirDukkani.Business.Abstract
{
    public interface ISkorService
    {
        IResult SkorEkle(OyunDurumu durum, int eklenecekPuan);
        IResult SkorDus(OyunDurumu durum, int dusulecekPuan);
        IDataResult<bool> OyunBittiMiKontrolEt(OyunDurumu durum);
    }
}
