using System.Security.Cryptography;

namespace Tombok_szamokkal
{
    internal class Program
    {
        static Random r = new Random();
        static int[] tomb = new int[15];
        static void Feltolt()
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = r.Next(-20,21);
            }
            foreach(var item in tomb)
            {
                Console.Write(item + " ");
            };
        }
        static void Osszegzes_tetel()
        {
            int osszeg = 0;
            foreach (var item in tomb)
            {
                osszeg += item;
            }
            Console.WriteLine($"a számok összege: {osszeg}");
        }
        static void Megszamlalas_tetel()
        {
            int db = 0;
            foreach (var item in tomb)
            {
                if (item < 0)
                {
                    db++;
                }
            }
            Console.WriteLine($"a pozitív számok darabszáma: {db}");
        }
        static void Eldontes_tetel()
        {
            int i = 0;
            while(i < tomb.Length && tomb[i] != 0)
            {
                i++;
            }
            if (i < tomb.Length)
            {
                Console.WriteLine("Van 0 a tömben");
            }
            else
            {
                Console.WriteLine("Nincs 0 a tömben");
            }
        }
        static void Kereses()
        {
            int keresett = 0;
            int i = 0;
            while (i < tomb.Length && tomb[i] != keresett)
            {
                i++;
            }
            if (i < tomb.Length)
            {
                Console.WriteLine($"A keresett szám a tömb {i}. indexén található");
            }
            else
            {
                Console.WriteLine("A keresett szám nincs a tömben");
            }
        }
        static void Kivalasztas()
        {
            tomb[8] = 10;
            int i = 0;
            while (tomb[i] != 10)
            {
                i++;
            }
            Console.WriteLine($"A keresett szám az {1 +1}. helyen található");
        }
        static void Main(string[] args)
        {
            Feltolt();
            Osszegzes_tetel();
            Megszamlalas_tetel();
            Eldontes_tetel();
            Kereses();
            Kivalasztas();
        }
    }
}
