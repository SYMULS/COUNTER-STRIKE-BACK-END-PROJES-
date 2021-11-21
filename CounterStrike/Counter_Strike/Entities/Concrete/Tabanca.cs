using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Counter_Strike.Enums;

namespace Counter_Strike.Entities.Concrete
{
    public class Tabanca : AtesliSilah
    {
        public Tabanca()
        {
            MermiSayisi = (int)MermiKapasitesi.bir;
            MermiTipi = MermiTipi.cekirdekli;
            AtesSesi = @"..\..\Sound\Tabanca.wav";
            SarjorSesi = @"..\..\Sound\Tabanca.wav";
        }
    }
}
