using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapselung
{
    internal class Person
    {
        private int intensity;
        private int duration;

        public bool atMax()
        {
            return intensity == 100;
        }

        public Color headColor()
        {
            if (intensity == 50)
            {
                return Color.Orange;

            }
            return Color.Yellow;
        }

        public string Signs()
        {
            return "";
        }
        
        public void Provoziere(int amount)
        {
            intensity += amount / 2;
        }

        public void Zureden(int amount)
        {
            intensity -= amount / 2;
        }
    }
}
