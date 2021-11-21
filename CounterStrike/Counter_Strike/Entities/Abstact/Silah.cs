using Counter_Strike.Enums;
using Counter_Strike.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Counter_Strike.Entities.Abstact
{
    public abstract class Silah : ISilah
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public decimal Agirlik { get; set; }
        public MenzilTipi menzilTipi { get; set; }

        public string Oldur()
        {
            SoundPlayer sp = new SoundPlayer(@"..\..\Sound\death.wav");
            sp.Play();
            return "ÖLDÜRÜLDÜ";
        }

        public string Yarala()
        {
            SoundPlayer sp = new SoundPlayer(@"..\..\Sound\scream.wav");
            sp.Play();
            return "YARALANDI";
        }
    }
}
