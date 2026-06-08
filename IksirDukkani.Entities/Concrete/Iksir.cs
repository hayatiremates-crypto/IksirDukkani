using IksirDukkani.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace IksirDukkani.Entities.Concrete
{
    public class Iksir : OyunNesnesi,ICraftable
    {
        public string TarifKodu { get; set; }

        public override void BilgiVer()
        {
            Console.WriteLine($"-{Ad} -> Formül: {TarifKodu}");
        }

        public bool UretilebilirMi(string girilenKod)
        {
            return TarifKodu == girilenKod;
        }

    }
}
