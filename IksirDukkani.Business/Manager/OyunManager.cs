using IksirDukkani.Business.Abstract;
using IksirDukkani.Core.Constants;
using IksirDukkani.DataAccess.Abstract;
using IksirDukkani.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IksirDukkani.Business.Manager
{
    public class OyunManager: IOyunService
    {
        private readonly IVeriDal _veriDal;
        private List<Iksir> _tarifDefteri;

        public OyunManager(IVeriDal veriDal)
        {
            _veriDal = veriDal;
            TarifDefteriniOlustur();
        }

        private void TarifDefteriniOlustur()
        {
            _tarifDefteri = new List<Iksir>
          {
           new Iksir {Id = 1,Ad =OyunSabitleri.IksirGorunmezlik, TarifKodu = "1 2"},
           new Iksir {Id = 2,Ad =OyunSabitleri.IksirHiz, TarifKodu = "3 1 2"},
           new Iksir {Id = 3,Ad =OyunSabitleri.IksirGuc, TarifKodu = "2 2 3"}
          };
        }

        public OyunDurumu OyunuBaslat()
        {
            return _veriDal.Yukle();
        }
        public void OyunuKaydet(OyunDurumu durum)
        {
            _veriDal.Kaydet(durum);
        }
        public List<Iksir> TarifDefteriniGetir()
        {
            return _tarifDefteri;
        }
        public Iksir RastgeleSiparisVer()
        {
            Random rnd = new Random();
            int index = rnd.Next(_tarifDefteri.Count);
            return _tarifDefteri[index];
        }
        
    }
}
