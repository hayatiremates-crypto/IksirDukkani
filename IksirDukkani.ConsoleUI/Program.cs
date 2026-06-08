using IksirDukkani.Business.Manager;
using IksirDukkani.ConsoleUI;
using IksirDukkani.DataAccess.Abstract;
using IksirDukkani.DataAccess.Concrete;
using IksirDukkani.Entities.Concrete;
using IksirDukkani.Entities.Enums;
using System.Threading.Tasks.Sources;

JsonVeriDal veriDal= new JsonVeriDal();
OyunManager oyunManager = new OyunManager(veriDal);
SiparisManager siparisManager = new SiparisManager();
SkorManager skorManager= new SkorManager();

ConsoleOyunEkrani ekran = new ConsoleOyunEkrani();
ConsoleGirdiOkuyucu girdiOkuyucu = new ConsoleGirdiOkuyucu();

OyunDurumu durum = oyunManager.OyunuBaslat();

while (durum.AnlikDurum == IksirDukkani.Entities.Enums.OyunDurumTipi.DevamEdiyor)
{
    Iksir istenenIksir = oyunManager.RastgeleSiparisVer();
    Musteri musteri = new Musteri { Ad = "Agatha", Krallik = "Evergreen", IstenenIksirAd = istenenIksir.Ad };

    bool siparisTamamlandiMi = false;

    while (!siparisTamamlandiMi)
    {
        ekran.AnaEkranıCiz(durum, musteri);

        GirdiTipi secim = girdiOkuyucu.AnaMenuSecimiAl();

        if (secim == GirdiTipi.TarifDefteriAc)
        {
            ekran.TarifDefteriniCiz(oyunManager.TarifDefteriniGetir());
        }
        else if (secim == GirdiTipi.IksirHazirla)
        {
            string girilenFormul = girdiOkuyucu.IksirFormuluAl();

            var siparisSonucu = siparisManager.SiparisKontrolEt(istenenIksir, girilenFormul);

            if (siparisSonucu.BasariliMi)
            {
                var skorSonucu = skorManager.SkorEkle(durum, IksirDukkani.Core.Constants.OyunSabitleri.DogruSiparisOdulu);
                ekran.MesajYazdir(siparisSonucu.Mesaj + "\n" + skorSonucu.Mesaj);
            }
            else
            {
                var skorSonucu = skorManager.SkorDus(durum, IksirDukkani.Core.Constants.OyunSabitleri.YanlisSiparisCezasi);
                ekran.MesajYazdir(siparisSonucu.Mesaj + "\n" + skorSonucu.Mesaj);
            }
            siparisTamamlandiMi = true;
        }

        else if (secim == GirdiTipi.CikisYap)
        {
            oyunManager.OyunuKaydet(durum);
            ekran.MesajYazdir("Oyun başarıyla kaydedildi.");
            return;
        }
        else 
        {
            ekran.MesajYazdir("Hatalı bir tuşa bastın.");
        }
    }

    var bitisKontrol = skorManager.OyunBittiMiKontrolEt(durum);
    if (bitisKontrol.BasariliMi)
    {
        ekran.MesajYazdir(bitisKontrol.Mesaj);
    }
}

