using IksirDukkani.Business.Abstract;
using IksirDukkani.Core.Results;
using IksirDukkani.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IksirDukkani.Business.Manager
{
    public class SiparisManager : ISiparisService
    {
        public IResult SiparisKontrolEt(Iksir istenenIksir, string oyuncuGirdisi)
        {
            //UretilebilirMi yi çağırıyoruz
            bool dogruMu = istenenIksir.UretilebilirMi(oyuncuGirdisi);

            if (dogruMu)
            {
                return new Result(true, "Mükemmel bir iksir! Böylesine bir büyü yeteneği görmedim!");
            }

            else 
            {
                return new Result(false, "Beni zehirlemeye mi çalışıyorsun? Bir an önce kapat bu dükkanı!!");
            }
        }
    }
}
