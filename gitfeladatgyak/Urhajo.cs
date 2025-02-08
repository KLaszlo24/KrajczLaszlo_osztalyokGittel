using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace gitfeladatgyak
{
    internal class Urhajo
    {

        private string nev;
        private int sebesseg;
        private int utaskapacitas;
        private int uzemanyagSzint;

        public Urhajo(string nev, int sebesseg, int utaskapacitas, int uzemanyagSzint)
        {
            this.nev = nev;
            this.sebesseg = sebesseg;
            this.utaskapacitas = utaskapacitas;
            this.uzemanyagSzint = uzemanyagSzint;
        }

        public Urhajo(string nev, int utaskapacitas)
        {
            this.nev = nev;
            this.utaskapacitas = utaskapacitas;
            sebesseg = 0;
            uzemanyagSzint=100;
        }

        public string Nev { get => nev; set => nev = value; }
        public int Sebesseg { get => sebesseg; set => sebesseg = value; }
        public int Utaskapacitas { get => utaskapacitas; set => utaskapacitas = value; }
        public int UzemanyagSzint { get => uzemanyagSzint; set => uzemanyagSzint = value; }


        public void Indulas()
        {
            Console.WriteLine($"A sebesség: {sebesseg += 10} és az üzemanyag szintje: {uzemanyagSzint -= 20}");
        }

        public int Tankolas(int mennyiseg)
        {
            return uzemanyagSzint += mennyiseg;
        }

        public int Landolas()
        {
            return sebesseg = 0;
        }

        public override string? ToString() 
        {
            return $"{nev}. Sebessége: {sebesseg}, utaskapacitása: {utaskapacitas}, üzemanyagszintje: {uzemanyagSzint}";
        }
    }
}
