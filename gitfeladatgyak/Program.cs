namespace gitfeladatgyak
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Könyv konyv1 = new("A kis herceg", "Antoine de Saint-Exupéry", 1943, 96, 2500);
			Könyv konyv2 = new("Ez még készül", "Én"); //kijelöl, quick action és new


            Console.WriteLine(konyv1.ToString()+ "\n"+ konyv2.ToString());

			konyv1.Kedvezmeny(20);
			konyv1.Arnoveles(1000);
			

			Console.WriteLine( "\n" + konyv1.ToString() + "\n" + konyv1.HanyoldalMaradt(20)); ;
		}
	}
}
