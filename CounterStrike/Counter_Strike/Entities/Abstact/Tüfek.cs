using Counter_Strike.Entities.Concrete;
using Counter_Strike.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter_Strike.Entities.Abstact
{
    public abstract class Tüfek : AtesliSilah, IYakinlas, IUzaklas
    {
        public TufekTipi TufekTipi { get; set; }


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
