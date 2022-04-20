using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace RecursiveFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tanım
            //Recursive Func: Kendi içerisinde kendisini çağıran fonksiyonlardır.
            //Tekrarlamalı/Özyinelemeli

            //Recursive Fonksiyonlar bir yaklaşımdır.
            #region Amaç
            /*Öngörülemeyen, derinliği tahmin edilemeyen, sonu bilinmeyen durumlarda tercih edilebilir.
             * 
             */
            #endregion
            #endregion

            #region Örnekler
            //Döngülerin kullanıldığı her noktada recursive func'lar KULLANILABİLİR; fakat recursive func. kullanılan her yerde döngü KULLANILAMAZ!
            #region Örnek-1
            //Belirli bir değer aralığındaki 5'in katı olan tüm sayıları toplayan bir rec. func. yazalım

            //int number1 = 100, number2 = 500;

            //for (int i = s1; i < s2; i++)
            //{
            //    //

            //}

            Console.WriteLine(Plus(10, 20));

            int Plus(int start, int end)
            {
                if(start % 5 == 0)
                {
                    return start + Plus(++start, end);
                }
                if (start < end)
                {
                    return Plus(++start, end);
                }
                return 0;
            }
            #endregion
            #region Örnek-2
            //Bir klasör dizisindeki bütün dosyaları listelememizi sağlayan bir yazılım oluşturursak

            List<FileInfo> files = PrintFiles("C:/Users/Poseidon/Desktop/Documentation");
            foreach (FileInfo file in files)
            {
                Console.WriteLine(file.FullName);
            }

            List<FileInfo> PrintFiles(string path)
            {
                List<FileInfo> files = new List<FileInfo>();
                DirectoryInfo directoryInfo = new DirectoryInfo(path);
                DirectoryInfo[] directoryInfos= directoryInfo.GetDirectories();

                if (directoryInfos.Any())
                {
                    foreach (DirectoryInfo directory in directoryInfos)
                    {
                        files.AddRange(PrintFiles(directory.FullName));
                    }
                }
                else
                    files.AddRange(directoryInfo.GetFiles());

                return files;

            }
            #endregion
            #endregion

            //X();

            //void X(int a = 1) //Recursive
            //{
            //    Console.WriteLine("Test");
            //    if (a<=3)
            //    {
            //        Console.WriteLine("Completed");
            //        X(++a);
            //    }

            //}

            //void X(int a = 1) //Recursive fonksiyonlarda parametreler aracılığıyla kontrol sağlayabiliriz.
            //{
            //    Console.WriteLine("Test");
            //    if (a < 3)
            //    {
            //        X(++a);
            //    }

            //}

            //void X() //Recursive
            //{
            //    Console.WriteLine("Test");
            //    X();
            //}



        }
    }
}
