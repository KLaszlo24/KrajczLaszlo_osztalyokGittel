using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitfeladatgyak
{
    internal class KemKuldetes
    {
        private string kodnev;
        private string orszag;
        private int veszelySzint;
        private double sikerEsej;

        public KemKuldetes(string kodnev, string orszag, int veszelySzint, double sikerEsej)
        {
            this.kodnev = kodnev;
            this.orszag = orszag;
            this.veszelySzint = veszelySzint;
            this.sikerEsej = sikerEsej;
        }

        public KemKuldetes(string kodnev, string orszag)
        {
            this.kodnev = kodnev;
            this.orszag = orszag;
            veszelySzint = 5;
            sikerEsej = 50;
        }

        public string Kodnev { get => kodnev; set => kodnev = value; }
        public string Orszag { get => orszag; set => orszag = value; }
        public int VeszelySzint { get => veszelySzint; set => veszelySzint = value; }
        public double SikerEsej { get => sikerEsej; set => sikerEsej = value; }


        public void KuldetesInditasa()
        {
            Console.WriteLine("A küldetés elkezdődött!");
        }

        public int VeszelySzintNovelese(int mennyiseg)
        {
            return veszelySzint += mennyiseg;
        }

        public double SikerEsejNovelese(double szazalek)
        {
            return sikerEsej+= sikerEsej*(szazalek/100);
        }


        public override string? ToString()  // ? - ha null érték lenne akkor is visszadana
        {
            return $"{kodnev} - {orszag}. Veszélyszintje: {veszelySzint}, sikerszint: {sikerEsej}";
        }
    }

}
