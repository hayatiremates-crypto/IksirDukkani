using System;
using System.Collections.Generic;
using System.Text;

namespace IksirDukkani.Entities.Abstract
{
    public abstract class OyunNesnesi
    {
     public int Id { get; set; }
     public string Ad { get; set; }

        public virtual void BilgiVer()
        {
            Console.WriteLine("Bu bir oyun nesnesidir");
        }
    }
}
