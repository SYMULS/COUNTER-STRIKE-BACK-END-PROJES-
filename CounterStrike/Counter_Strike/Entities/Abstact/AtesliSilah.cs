using Counter_Strike.Entities.Abstact;
using Counter_Strike.Enums;
using Counter_Strike.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Counter_Strike.Entities.Concrete
{
    public abstract class AtesliSilah : Silah, IAtesliSilah
    {
        public MermiTipi MermiTipi { get; set; }

        public MermiKapasitesi MermiKapasitesi { get; set; }
        public int MermiSayisi { get; set; }
        public decimal Kalibre { get; set; }
        public string AtesSesi { get; set; }
        public string SarjorSesi { get; set; }

        public string AtesEt()
        {
            Random rnd = new Random();
            if (MermiSayisi > 0)
            {
                SoundPlayer sp = new SoundPlayer();
                sp.SoundLocation = AtesSesi;
                sp.Play();
                MermiSayisi--;

                
                int sayi = rnd.Next(1, 7); //7 hariç
                if (sayi == 2) // 2 olması önemli değil isteediğini ver
                {
                    return "Adam" + Oldur();
                }
                else
                {
                    return "Adam" + Yarala();
                }
            }
            else
            {
                SarjorDoldur();
                return "Mermi yoktu fulledik!";
            }
        }

        public virtual string SarjorDoldur()
        {
            MermiSayisi =(int)MermiKapasitesi;
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = SarjorSesi;
            sp.Play();
            return "Şarjor artık full!";
        }
    }
}
