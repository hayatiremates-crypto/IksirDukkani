using IksirDukkani.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace IksirDukkani.Entities.Concrete
{
    public class OyunDurumu
    {
        public int Puan { get; set; }
        public OyunDurumTipi AnlikDurum { get; set; }

        public OyunDurumu()
        {
            Puan = 0;
            AnlikDurum = OyunDurumTipi.DevamEdiyor;
        }
    }
}
