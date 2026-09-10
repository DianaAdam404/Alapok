using System;
using System.Collections.Generic;
using System.Text;

namespace Bankszamla
{
    internal class Bankszam
    {
        private double egyenleg=10000;
        public void Befizetes(double osszeg)
        {
            if (osszeg > 0)
            {
                egyenleg += osszeg;
                Console.WriteLine($"Befizetes:{osszeg} Ft. Uj egyenleg:{egyenleg} Ft.");
            }
            else
            {
                Console.WriteLine("A befizetes osszege nem lehet negativ.");
            }
        }
        public void Kivet(double osszeg)
        {
            if (osszeg > 0 && osszeg <= egyenleg)
            {
                egyenleg -= osszeg;
                Console.WriteLine($"Kifizetes:{osszeg} Ft. Uj egyenleg:{egyenleg} Ft.");
            }
            else
            {
                Console.WriteLine("A kifizetes osszege nem lehet negativ vagy nagyobb, mint az egyenleg.");
            }
            //void = hatterben mukodik
        }
    }
}
