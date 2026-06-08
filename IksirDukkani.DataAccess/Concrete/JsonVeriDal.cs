using IksirDukkani.DataAccess.Abstract;
using IksirDukkani.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace IksirDukkani.DataAccess.Concrete
{
    public class JsonVeriDal : IVeriDal
    {
        private readonly string _dosyaYolu = "iksirDukkaniKayit.json";

        public void Kaydet(OyunDurumu durum)
        {
            string jsonMetni = JsonSerializer.Serialize(durum);

            File.WriteAllText(_dosyaYolu, jsonMetni);
        }
        public OyunDurumu Yukle()
        {
            if (!File.Exists(_dosyaYolu))
            {
                return new OyunDurumu();
            }

            string jsonMetni = File.ReadAllText(_dosyaYolu);

            //Okunan json metnini tekrar OyunDurumu yapar.
            OyunDurumu kayitliDurum = JsonSerializer.Deserialize<OyunDurumu>(jsonMetni);

            return kayitliDurum;
        }
    }
}
