using System;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yerleştirme Kursu";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "java";
            string kurs4 = "Phyton";
            string kurs5 = "C++";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);


            //array diziler
            string[] kurslar = new string[] { "Yazılım Geliştirici Yerleştirme Kursu",
                "Programlamaya başlangıç için temel kurs", "java", "Phyton", "C++"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
