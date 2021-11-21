using Counter_Strike.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Counter_Strike.Entities.Concrete
{
    public class Roket : AtesliSilah, IYakinlas, IUzaklas
    {
        public Roket()
        {
            MermiSayisi = (int)MermiKapasitesi.bir;
            MermiTipi = MermiTipi.roket;
            AtesSesi = @"..\..\Sound\TopAtis.wav";
            SarjorSesi = @"..\..\Sound\PompaliSarjor.wav";
        }
        public string Uzaklas()
        {
            return "Uzaklaşıldı";
        }
        public string Yakinlas()
        {
            return "Yakınlaşıldı";
        }
    }
}
