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
            Console.WriteLine();


            Console.WriteLine("Változtatott adatok: ");
            Console.WriteLine("\n" + film1.ToString() + "\n" + "új hossz:" + film1.Hossznoveles(50));
			Console.WriteLine("\n" + film2.ToString() + "\n" + "új hossz:" + film2.Hossznoveles(60));

			Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("A harmadik feladat-Videójáték karakter");

			Videójáték_karakter karak1 = new("Naruto", 3, 200, 100);
			Videójáték_karakter karak2 = new("Pókember", 30); //kijelöl, quick action és new


			Console.WriteLine(karak1.ToString() + "\n" + karak2.ToString());
			Console.WriteLine();
			karak1.Tamadas();
			karak2.Tamadas();
            Console.WriteLine();
            Console.WriteLine(karak1.Nev);
			karak1.Szintlepes();
			Console.WriteLine();
			Console.WriteLine(karak2.Nev);
			karak2.Szintlepes();

			Console.WriteLine();


			Console.WriteLine("Változtatott adatok: ");
			Console.WriteLine("\n" + karak1.ToString() + "\n" + "új gyógyulás:" + karak1.Gyogyulas(30));
			Console.WriteLine("\n" + karak2.ToString() + "\n" + "új gyógyulás:" + karak2.Gyogyulas(60));


            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("A negyedik feladat-Űrhajó");

            Urhajo urhajo1 = new("Kishajó", 100, 50, 400);
            Urhajo urhajo2 = new("Énhajó", 200); 


            Console.WriteLine(urhajo1.ToString() + "\n" + urhajo2.ToString());
            Console.WriteLine();
            Console.WriteLine("Elindulás utáni adatok:");
            Console.WriteLine(urhajo1.Nev);
            urhajo1.Indulas();
            Console.WriteLine(urhajo2.Nev);
            urhajo2.Indulas();
            Console.WriteLine();

            Console.WriteLine();


            Console.WriteLine("Változtatott adatok: ");
            Console.WriteLine("\n" + urhajo1.ToString() + "\n" + "Tankolás:" + urhajo1.Tankolas(45) + "Landolási sebesség:" + urhajo1.Landolas());
            Console.WriteLine("\n" + urhajo2.ToString() + "\n" + "Tankolás:" + urhajo2.Tankolas(60) + "Landolási sebesség:" + urhajo2.Landolas());



            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Az ötödik feladat-KémKüldetés");

            KemKuldetes kuld1 = new("Nagyfutas", "Anglia", 30, 80);
            KemKuldetes kuld2 = new("Énfeladat", "Magyarország");


            Console.WriteLine(kuld1.ToString() + "\n" + kuld2.ToString());
            Console.WriteLine();
            Console.WriteLine("Küldetés kezdete:");
            Console.WriteLine();
            Console.WriteLine(kuld1.Kodnev);
            kuld1.KuldetesInditasa();
            Console.WriteLine();
            Console.WriteLine(kuld2.Kodnev);
            kuld2.KuldetesInditasa();
            Console.WriteLine();

            Console.WriteLine();


            Console.WriteLine("Változtatott adatok: ");
            Console.WriteLine("\n" + kuld1.ToString() + "\n" + "Űj veszély:" + kuld1.VeszelySzintNovelese(30) + "\n" + "Új Siker esély:" + kuld1.SikerEsejNovelese(14));
            Console.WriteLine("\n" + kuld2.ToString() + "\n" + "Új veszély:" + kuld2.VeszelySzintNovelese(40) + "\n" +  "Új Siker esély:" + kuld2.SikerEsejNovelese(23));
        }
	}
}
