using System;

namespace OutAndTryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Out Keyword'ü
            /* Metotların parametreleri üzerinden dışarıya değer göndermemizi sağlayan bir keyword'dür.
             * Bir metodun parametreleri varsayılan olarak input'tur.
             * Eğer bir metodun parametresiyle dışarıya değer çıkarılacaksa, o parametrenin out keyword'ü ile işaretlenmesi gerekir.
             * 
             */
            #region 1. Kullanım
            //int _b = 0;
            //string _d = "";
            //int a = X(out _b, 123, out _d);
            #endregion
            #region 2. Kullanım
            X(out int _b, 123, out string _d);

            Console.WriteLine(_b);
            Console.WriteLine(_d);
            #endregion
            //Bir metot out parametreleri barındırıyorsa o parametrelere kendi içerisinde değer ataması yapılmalıdır.
            //Yapılmazsa, derleyici hatası alınır.
            int X(out int b, int c, out string d)
            {
                b = 25;
                d = "Onur";
                return 0;
            }

            #endregion
            #region TryParse
            string a = "123";

            if (int.TryParse(a, out int r))
            {
                Console.WriteLine(r); ;
            }
            else
            {
                Console.WriteLine(a);
            }
            #endregion
        }
    }
}
