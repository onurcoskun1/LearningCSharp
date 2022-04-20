using System;

namespace LocalFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            X();
            
            #region Local Functions
            //Bir metot içerisinde tanımlanmış metotlardır.
            #region Tanımlama Kuralları
            /* 1- Erişim belirleyicisi yazılmaz.
             * 2- Local funtion olarak tanımlanan fonksiyon adı, tanımlandığı fonksiyonun adından farklı olmalıdır.
             *    Eğer aynı olursa, local function, ana metodu ezecektir. Derleme hatası VERMEZ! 
             */
            #endregion
            #region Kullanım Kuralları
            // Bir local function, sadece tanımlandığı metodun içerisinde kullanılabilir.
            // Local function tanımlandığı metodun içerisinden her yerden erişilebilir. (öncesi ve sonrasında)
            #endregion
            #region Amacı
            //Local function'lar, sadece tek bir metodda tekrarlı bir şekilde kullanılacak bir algoritmayı/işlemi o metoda özel tek seferlik tanımlamamızı
            // ve kullanmamızı sağlamaktadır.
            #endregion
            #endregion
        }


        public static int X()
        {
            Y();
            
            //Local function'larda erişim belirleyicisi yoktur!
            void Y()
            {
                Console.WriteLine("Test");
            }

            Y();

            return 0;
        }
    }
}
