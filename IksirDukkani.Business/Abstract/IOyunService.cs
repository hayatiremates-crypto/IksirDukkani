using IksirDukkani.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IksirDukkani.Business.Abstract
{
    public interface IOyunService
    {
        OyunDurumu OyunuBaslat();
        void OyunuKaydet(OyunDurumu durum);
        List<Iksir> TarifDefteriniGetir();
        Iksir RastgeleSiparisVer();
       
        
    }
}
