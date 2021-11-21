using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Counter_Strike.Enums;
using Counter_Strike.Entities.Abstact;

namespace Counter_Strike.Entities.Concrete
{
    public class TaramaliTufek : Tüfek
    {
        public TaramaliTufek()
        {
            MermiSayisi = (int)MermiKapasitesi.elli;
            MermiTipi = MermiTipi.cekirdekli;
            TufekTipi = TufekTipi.Taramali;
            AtesSesi = @"..\..\Sound\Silah2.wav";
            SarjorSesi = @"..\..\Sound\Silah2.wav";
        }
    }
}
