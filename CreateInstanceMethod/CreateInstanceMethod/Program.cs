using System;

namespace CreateInstanceMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] yaslar1 = new int[3];
            //Normalde yukarıdaki gibi yapabildiğimiz dizi tanımlaması, arka planda Array sınıfının aşağıdaki metodunu kullanmaktadır.
            //İstersek aşağıdaki gibi de oluşturabiliyoruz. Fakat önceki konularda bahsedildiği gibi, sadece fonksiyonel olarak dizi kullanacaksak bu mantıklı bir karar olmuş oluyor.
            Array yaslar =  Array.CreateInstance(typeof(int), 3);

            #region Ranges and Indices
            //int[] sayilar = { 3, 4, 5, 6, 7, 8, 15, 9, 10 };
            //Index index = ^2;

            //Console.WriteLine(sayilar[index]);


            #region Ranges
            //Koleksiyonlarda hangi değerlerde çalışacağımızı seçmemizi sağlayan yapıdır.
            int[] sayilar = { 3, 4, 5, 6, 7, 8, 15, 9, 10, 15, 26, 11, 33, 34, 35 };

            //Range range = 2..6;
            //var sayilar2 = sayilar[range];

            /*Range range = ..;*/ //--> Tüm diziye karşılık gelir.
                                  //İlgili diziyi komple kopyalamak için pratik bir yöntemdir.
                                  //var sayilar1 = sayilar[range];

            //Range range = 2..^5;
            //var sayiliar2 = sayilar[range];

            //Range range = ^2..^5;
            //var sayilar2 = sayilar[range];

            #region .. Operatörü

            //Index i1 = 2, i2 = ^5;
            //Range range = i1..i2;
            //var sayilar2 = sayilar[range]; 
            //var sayilar2 = sayilar[i1..i2];

            //int sayi = sayilar[^1];
            //Console.WriteLine(sayi);
            #endregion

            #region ^ Operatörü
            // Operatörü kullanabilmek için Index türünü kullanmamız gereklidir!

            Index i = ^6;
            Console.WriteLine(sayilar[i]);
            #endregion






            #endregion
            #endregion
        }
    }
}
