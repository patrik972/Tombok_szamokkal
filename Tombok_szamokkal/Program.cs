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
        static void Main(string[] args)
        {
            Feltolt();
            Osszegzes_tetel();
            Megszamlalas_tetel();
        }
    }
}
