using System;
using System.Collections.Generic;
using System.Text;

namespace Valuta
{
    public class ValutaValto
    {
        public double Arfolyam;

        public double EurorolHuf(double euro)
        {
            
            return euro * Arfolyam;
        }

        public double FixEurorolHuf(double euro)
        {
            return euro * 400;
        }


    }
}
