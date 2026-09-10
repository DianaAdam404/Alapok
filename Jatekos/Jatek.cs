using System;
using System.Collections.Generic;
using System.Text;

namespace Jatekos
{
    public class Jatek
    {
        private int elet;
        public string Nev { get; set; }
        public int Elet 
        {
            get { return elet; }

            set
            {
                if (value < 0) elet = 0;
                else if (value >100) elet = 100;
                else elet = value;
            }
        }

    }
}
