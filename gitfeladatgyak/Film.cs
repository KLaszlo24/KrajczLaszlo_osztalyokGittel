using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitfeladatgyak
{
	internal class Film
	{
		private string cim;
		private string rendezo;
		private int hosszPercekben;
		private string mufaj;
		private bool megjelent;

		public string Cim { get => cim; set => cim = value; }
		public string Rendezo { get => rendezo; set => rendezo = value; }
		public int HosszPercekben { get => hosszPercekben; set => hosszPercekben = value; }
		public string Mufaj { get => mufaj; set => mufaj = value; }
		public bool Megjelent { get => megjelent; set => megjelent = value; }

		public Film(string cim, string rendezo, int hosszPercekben, string mufaj, bool megjelent)
		{
			this.cim = cim;
			this.rendezo = rendezo;
			this.hosszPercekben = hosszPercekben;
			this.mufaj = mufaj;
			this.megjelent = megjelent;
		}

		public Film(string cim, string rendezo)
		{
			this.cim = cim;
			this.rendezo = rendezo;
			hosszPercekben = 120;
			mufaj = "ismeretlen";
			megjelent = false;

		}

		public void Jatszas()
		{
			if (megjelent == true)
			{
                Console.WriteLine("A film elkezdődött.");
            }
			else
			{
                Console.WriteLine("A film nem kezdődött el");
            }
               
		}
		public void MufajModositas(string ujMufaj)
		{
			mufaj = ujMufaj;
        }

		public int Hossznoveles(int percek)
		{
			return hosszPercekben += percek;
		}

		public override string? ToString()  // ? - ha null érték lenne akkor is visszadana
		{
			return $"{cim} - {rendezo} / {hosszPercekben} / {mufaj} - {megjelent}";
		}



	}
}
