using IksirDukkani.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IksirDukkani.DataAccess.Abstract
{
    public interface IVeriDal
    {
        void Kaydet(OyunDurumu durum);

        OyunDurumu Yukle();
    }
}
