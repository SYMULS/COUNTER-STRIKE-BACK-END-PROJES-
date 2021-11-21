using Counter_Strike.Entities.Abstact;
using Counter_Strike.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Counter_Strike.Entities.Concrete
{
    public class Bicak : Silah , IBile, IKes
    {
        public int KesmeSayisi { get; set; } = 5;

        public string Bile()
        {
            SoundPlayer sp = new SoundPlayer(@"..\..\Sound\SharpenKnife.wav");
            sp.Play();
            return "Jilet gibi oldu";

        }

        public string Kes()
        {
            SoundPlayer sp = new SoundPlayer(@"..\..\Sound\StabKnife.wav");
            sp.Play();
            if (KesmeSayisi >0)
            {
                KesmeSayisi--;
                return "Adam" + Yarala();
            }
            else
            {
                KesmeSayisi = 5;
                return "Adam" + Oldur();
            }
        }
    }
}
