using System;

namespace KampIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // type safety tip güvenliği
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmismı = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("azalış butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }



            if (sistemeGirisYapmismı == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }


            Console.WriteLine(kategoriEtiketi);

        }
    }
}
