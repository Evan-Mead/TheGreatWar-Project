using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGreatWar
{
    class Weapon_Type
    {
        public string fist;
        public string hologram;
        public string laser;

        public Weapon_Type(string fist, string hologram, string laser)
        {
            this.fist = fist;
            this.hologram = hologram;
            this.laser = laser;
        }
    }
}