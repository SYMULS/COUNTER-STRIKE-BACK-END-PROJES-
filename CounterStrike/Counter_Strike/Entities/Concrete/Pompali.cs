using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Counter_Strike.Enums;
using Counter_Strike.Entities.Abstact;
using System.Media;

namespace Counter_Strike.Entities.Concrete
{
    public class Pompali : Tüfek
    {
        public Pompali()
        {
            MermiSayisi = (int)MermiKapasitesi.dort;
            MermiTipi = MermiTipi.cekirdekli;
            TufekTipi = TufekTipi.Taramali;
            AtesSesi = @"..\..\Sound\Pompali.wav";
            SarjorSesi = @"..\..\Sound\PompaliSarjor.wav";
        }
        public override string SarjorDoldur()
        {
            SoundPlayer sp = new SoundPlayer();

            for (int i = 0; i < 4; i++)
            {
                MermiSayisi++;              
                sp.SoundLocation = SarjorSesi;
                sp.Play();
            }
            return "Şarjör dolduruldu";
        }


    }
}
