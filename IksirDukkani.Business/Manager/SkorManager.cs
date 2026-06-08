using IksirDukkani.Business.Abstract;
using IksirDukkani.Core.Constants;
using IksirDukkani.Core.Results;
using IksirDukkani.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IksirDukkani.Business.Manager
{
    public class SkorManager: ISkorService
    {
        public IResult SkorEkle(OyunDurumu durum, int eklenecekPuan)
        {
            durum.Puan += eklenecekPuan;
            return new Result(true, $"Tebrikler! {eklenecekPuan} puan kazandın. Güncel Puan : {durum.Puan}");
        }
        public IResult SkorDus(OyunDurumu durum, int dusulecekPuan)
        {
            durum.Puan -= dusulecekPuan;
            return new Result(true, $"Olamaz! {dusulecekPuan} puan kaybettin. Güncel Puan : {durum.Puan}");
        }

        public IDataResult<bool> OyunBittiMiKontrolEt(OyunDurumu durum)
        { 
         if (durum.Puan >= OyunSabitleri.KazanmaHedefi)
         {
                durum.AnlikDurum = Entities.Enums.OyunDurumTipi.Kazanildi;

                return new DataResult<bool>(true, true, "YAŞASIN! Hedefine ulaştın. Artık Usta İksirci oldun!");
         }
            
            return new DataResult<bool>(false, true);
        }
    }
}
