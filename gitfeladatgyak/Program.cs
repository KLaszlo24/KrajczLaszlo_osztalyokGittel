using System;

namespace gitfeladatgyak
{
	internal class Program
	{
		static void Main(string[] args)
		{

            Console.WriteLine("Az első feladat-Könyv");
            Könyv konyv1 = new("A kis herceg", "Antoine de Saint-Exupéry", 1943, 96, 2500);
			Könyv konyv2 = new("Ez még készül", "Én"); //kijelöl, quick action és new


            Console.WriteLine(konyv1.ToString()+ "\n"+ konyv2.ToString());

			konyv1.Kedvezmeny(20);
			konyv1.Arnoveles(1000);
			

			Console.WriteLine( "\n" + konyv1.ToString() + "\n" + konyv1.HanyoldalMaradt(20));

            Console.WriteLine();

            Console.WriteLine("A második feladat-Film");

            Film film1 = new("Egy igazán dühös ember", "Guy Ritchie", 119, "akciófilm", true);
			Film film2 = new("Ez még készülő film", "Én"); //kijelöl, quick action és new


			Console.WriteLine(film1.ToString() + "\n" + film2.ToString());
            Console.WriteLine();
            Console.WriteLine(film1.Cim);
			film1.Jatszas();
            Console.WriteLine();
            Console.WriteLine(film2.Cim);
			film2.Jatszas();
			film1.MufajModositas("thriller");
			film2.MufajModositas("vígdráma");

            Console.WriteLine();


            Console.WriteLine("Változtatott adatok: ");
            Console.WriteLine("\n" + film1.ToString() + "\n" + "új hossz:" + film1.Hossznoveles(50));
			Console.WriteLine("\n" + film2.ToString() + "\n" + "új hossz:" + film2.Hossznoveles(60));
		}
	}
}
