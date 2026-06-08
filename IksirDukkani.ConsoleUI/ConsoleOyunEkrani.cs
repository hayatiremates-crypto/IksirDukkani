using IksirDukkani.Core.Constants;
using IksirDukkani.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IksirDukkani.ConsoleUI
{
    public class ConsoleOyunEkrani
    {
        public void AnaEkranıCiz(OyunDurumu durum, Musteri musteri)
        { 
            Console.Clear();
            Console.WriteLine("------------------------------");
            Console.WriteLine(OyunSabitleri.OyunBaslangicMesaji);
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Mevcut Puanın: {durum.Puan}/ {OyunSabitleri.KazanmaHedefi}");
            Console.WriteLine("------------------------------\n");

            musteri.BilgiVer();
        }
        public void TarifDefteriniCiz(List<Iksir> tarifler)
        {
            Console.WriteLine("\n--- TARİF DEFTERİ ---");
            Console.WriteLine("Malzemeler: 1-Kutsal Su, 2-Şifalı Ot, 3-Büyülü Mantar");

            foreach (var iksir in tarifler)
            {
                iksir.BilgiVer();
            }

            Console.WriteLine("\n" + OyunSabitleri.TarifDefteriKapatMesaji);
            Console.WriteLine("Devam etmek için Enter'a bas");
            Console.ReadLine();
        }

        public void MesajYazdir(string mesaj)
        {
            Console.WriteLine($"\n>{mesaj}");
            Console.WriteLine("Devam etmek için Enter'a bas");
            Console.ReadLine();
        }
    }
}
