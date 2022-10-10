using System;

namespace DegerveReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar2[0]);
            Console.WriteLine(sayilar2[1]);
            Console.WriteLine(sayilar2[2]);
        }
    }
}
