using System;

namespace CokBoyutluDiziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Çok Boyutlu Diziler
            //Çok boyutlu dizilerde indexer içerisinde "," ile tanımlanma yapılır. ,sayisi + 1 = dizi derecesidir.

            #region İki boyutlu dizi tanımlaması
            /*int[,] sayilar = new int[3, 5];*/ // x ve y koordinatları üzerinde düşünülebileceğimiz dizilerdir.


            #endregion

            #region İki Boyutludan Fazla Dizi Tanımlaması
            //int[,,,] sayilar = new int[3, 4, 5, 6]; //4 boyutlu bir dizi tanımlaması

            #endregion

            #region Tanımlanmış Çok Boyutlu Diziye Değer Ataması

            //int[,] sayilar = new int[3, 5];
            //sayilar[0, 0] = 1;

            //int[,,,] sayilar = new int[1, 2, 3, 5];

            //sayilar[0, 0, 0, 1] = 11;

            //int[,,] sayilar = new int[2, 3, 4];

            //sayilar[0, 0, 1] = 15;

            #region Farklı Varyasyonla Değer Atama

            //int[,] sayilar = { { 3, 5, 7 }, { 5, 6, 7 }, { 15, 11, 34 }, { 10, 11, 26 } };
            #endregion


            #endregion

            #region Verileri Ekrana Yazdırma
            //Boyut sayısı kadar döngü ile ekrana yazdırmamız gereklidir.

            int[,,] sayilar = new int[2, 2, 4];
            sayilar[0, 0, 0] = 1;
            sayilar[0, 0, 1] = 2;
            sayilar[0, 0, 2] = 3;
            sayilar[0, 0, 3] = 4;
            sayilar[0, 1, 0] = 5;
            sayilar[0, 1, 1] = 6;
            sayilar[0, 1, 2] = 7;
            sayilar[0, 1, 3] = 8;
            sayilar[1, 0, 0] = 9;
            sayilar[1, 0, 1] = 10;
            sayilar[1, 0, 2] = 11;
            sayilar[1, 0, 3] = 12;
            sayilar[1, 1, 0] = 13;
            sayilar[1, 1, 1] = 14;
            sayilar[1, 1, 2] = 15;
            sayilar[1, 1, 3] = 16;

            for (int i = 0; i < sayilar.GetLength(0); i++)
            {
                for (int j = 0; j < sayilar.GetLength(1); j++)
                {
                    for (int k = 0; k < sayilar.GetLength(2); k++)
                    {
                        Console.Write(sayilar[i,j,k] + "                 ");
                    }
                    Console.WriteLine();
                }
            }

            #endregion

            #endregion
        }
    }
}
