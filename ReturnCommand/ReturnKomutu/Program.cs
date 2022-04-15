using System;

namespace ReturnKomutu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region return
            // Kullanıcı "c" tuşuna basana kadar sonsuz döngüde dönen bir uygulama yazınız

            //while (true)
            //{
            //    if(Console.ReadKey().KeyChar == 'c')
            //    {
            //        Console.WriteLine("Uygulama sona ermiştir!");
            //        return;
            //    }
            //    else
            //    {
            //        Console.WriteLine("");
            //        Console.WriteLine("Uygulama çalışıyor...");
            //    }
            //}
            #endregion

            #region goto
            /* Geleneksel coderlar tarafından tavsiye edilmez.
             * Yapılmış olan performans testlerinde bir nebze de olsa kayıp ve yavaşlık tespit edilmiştir.
             * Maaliyeti bir nebze yükseltecektir. İyi bir programcının kullanmaması gerektiği kanaati vardır.
             */

            //switch (10)
            //{
            //    case 5:
            //        Console.WriteLine("asdjkasd");
            //        break;
            //    case 10:
            //        goto case 15;
            //    case 15:
            //        break;

            //}

            //a:

            //Console.WriteLine("Merhaba");
            //Console.WriteLine("Dünya");
            //goto a;

            #region Ornekler
            // 1'den 100 e kadar sayma programı

            //int i = 1;
            //a:
            //Console.WriteLine(i++);
            //if(i <=100)
            //    goto a;

            //for (int i = 0; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //}



            #endregion


            #endregion

        }
    }
}
