using IksirDukkani.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace IksirDukkani.ConsoleUI
{
    public class ConsoleGirdiOkuyucu
    {
        public GirdiTipi AnaMenuSecimiAl()
        {
            Console.WriteLine("\n[T] Tarif Defterine Bak | [H] İksiri Hazırla | [K] Kaydet ve Çık");
            Console.Write("Seçim yap: ");

            string secim = Console.ReadLine().ToUpper();

            if (secim == "T") return GirdiTipi.TarifDefteriAc;
            if (secim == "H") return GirdiTipi.IksirHazirla;
            if (secim == "K") return GirdiTipi.CikisYap;

            return GirdiTipi.HataliGirdi;

        }

        public string IksirFormuluAl()
        {
            Console.Write("\nLütfen malzemelerin numaralarını aralarında boşluk bırakarak gir (Örnek: 1 2): ");
            return Console.ReadLine();
        }
    }
}
