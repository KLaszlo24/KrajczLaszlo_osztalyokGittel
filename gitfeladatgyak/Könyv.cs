using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitfeladatgyak
{
	internal class Könyv
	{

		private string cim;
		private string szerzo;
		private int kiadasEve;
		private int oldalszam;
		private int ar;

		//konyv.Cim A sajt konyv.Cim="A sajt"
		//konyv.Cim="Cim"

		public string Cim { get => cim; set => cim = value; }
		public string Szerzo { get => szerzo; set => szerzo = value; }
		public int KiadasEve { get => kiadasEve; set => kiadasEve = value; }
		public int Oldalszam { get => oldalszam; set => oldalszam = value; }
		public int Ar { get => ar; set => ar = value; }

		public Könyv(string cim, string szerzo, int kiadasEve, int oldalszam, int ar)
		{
			this.cim = cim;
			this.szerzo = szerzo;
			this.kiadasEve = kiadasEve;
			this.oldalszam = oldalszam;
			this.ar = ar;
		}

		//alt enter
		public Könyv(string cim, string szerzo)
		{
			this.cim = cim;
			this.szerzo = szerzo;
			kiadasEve = DateTime.Now.Year; //nincs szükség itt a this-re mert tudja mi lesz
			oldalszam = 200;
			ar = 3000;
		}

		public void Arnoveles(int osszeg)
		{
			ar += osszeg;
		}

		public void Kedvezmeny(double szazalek)
		{
			int csokkentes = Convert.ToInt16(ar * (szazalek / 100));
			ar -= csokkentes;
		}

		public int HanyoldalMaradt(int elolvasott)
		{
			return oldalszam-elolvasott;  //mindenhol hozzáférhetőek a propertyk
		}

		public override string? ToString()  // ? - ha null érték lenne akkor is visszadana
		{
			return $"{cim} - {szerzo} / {oldalszam} / {kiadasEve} - {ar}";
		}
	}
}
