using System;

namespace ArraysGY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Sınırlılıklar
            /* 1- Dizi tanımlama sürecinde eleman sayısı girilmek zorundadır! Yani dizide çalışacak değer adedi başta bildirilmelidir. Bu bir sınırlılıktır.
             * 2- Diziler tanımlandığında kullansak da kullanmasak da bellekte belirtilen eleman sayısı kadar alan tahsisinde bulunurlar.
             *    Bu durumda bellek boyutunda ekstra maliyete sebep olacağından bu bir sınırlılıktır.
             * 3- Dizilerde eleman sayısının başta belirlenmesi, ihtiyaç durumunda daha fazla değer atamak istediğimizde bu değerleri atayamayacağımızdan ve dizinin aralığını genişletemeyeceğimizden
             *    dolayı bu durum bir sınırlılıktır.
             * 4- Dizilerde elemanlara değer atanırken, indexer operatörü ile çok ilişkili olunmaktadır. Bu bir sınırlılıktır.
             */
            #endregion

            #region Diziler - Arrays
            //Tek bir değişken altında birden fazla "aynı türde" değeri toplamamızı sağlayan veri kümelerine dizi denir.

            // Dizi tanımlama : (type)[] isim = new type[........]

            //int[] yaslar = new int[5];

            //bool[] x = new bool[7];

            //byte[] sayilar = new byte[15];

            //int[] yaslar = new int[7];

            //yaslar[0]= 







            #endregion

            #region Tanımlanmış Dizi İçerisinde Döngüyle Dönme
            //Diziler genellikle döngüler ile birlikte algoritmalarda kullanılmaktadır.

            //string[] personeller = new string[10];

            //personeller[0] = "Hilmi";
            //personeller[1] = "Hüseyin";
            //personeller[2] = "Onur";
            //personeller[3] = "Halit";
            //personeller[4] = "Ümit";
            //personeller[5] = "Devrim";
            //personeller[6] = "Gökcan";
            //personeller[7] = "Burak";
            //personeller[8] = "Ufuk";
            //personeller[9] = "Cem";

            //for (int i = 0; i < personeller.Length; i++)
            //{
            //    Console.WriteLine(personeller[i]);
            //}

            //int i = 0;
            //do
            //{
            //    Console.WriteLine(personeller[i++]);
            //} while (i<10);


            #endregion

            #region Dizi Tanımlama Varyasyonları
            #region 1. Varyasyon
            int[] yaslar = new int[3]; //En temel tanımlama yöntemi

            #endregion
            #region 2. Varyasyon
            int[] yaslar1 = { 30, 25, 41, 52 };
            string[] isimler = { "Onur", "Ümit", "Halit", "Devrim", "Cem" };

            #endregion
            #region 3. Varyasyon
            string[] isimler1 = new string[] { "Onur", "Ümit", "Halit", "Devrim", "Cem" };
            #endregion
            #region 4. Varyasyon
            string[] isimler2 = new string[3] { "Onur", "Ümit", "Halit" };
            #endregion
            #region 5. Varyasyon
            int[] sayilar3 = new[] { 3, 5, 7 };
            var sayilar4 = new[] { 4, 5, 6 };
            #endregion
            #endregion
        }
    }
}
