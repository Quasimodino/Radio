using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio
{
    internal class Radio
    {
        public float volume { get; set; }
        public float aumentavolume()
        {
            float vol= volume + volume / 10;
            return vol;
        }
        public float diminuiscivolume()
        {
            float vol = volume - volume / 10;
            return vol;
        }
    }
}
