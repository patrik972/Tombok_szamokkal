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
        static void Main(string[] args)
        {
            Feltolt();
        }
    }
}
