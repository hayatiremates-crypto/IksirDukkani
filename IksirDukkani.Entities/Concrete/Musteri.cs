using IksirDukkani.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace IksirDukkani.Entities.Concrete
{
    public class Musteri:OyunNesnesi
    {
        public string IstenenIksirAd { get; set; }
        public string Krallik { get; set; }

        public override void BilgiVer()
        {
            Console.WriteLine($"{Krallik} krallığından {Ad} dükkana girdi ve '{IstenenIksirAd}' sipariş etti.");
        }
    }
}
