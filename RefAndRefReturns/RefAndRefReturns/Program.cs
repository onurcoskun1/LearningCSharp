using System;

namespace RefAndRefReturns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ref Keyword'ü
            /* Referansın kısaltmasıdır.
             * Referanslarda "=" operatörü aracılığıyla herhangi nesnesel türeme söz konusu değildir.
             * İşlem yapılan nesne diğer referans tarafından işaretlenmiştir.
             * Yukarıda bahsedilen davranışı değer türlü değişkenlerde gerçekleştirmeyi sağlayan yapı ref keyword'üdür. 
             * Değer türlü değişkenlerin referans türlü değişkenler gibi çalışmasını sağlar.
             * Değer türlü değişkenlerde Shallow Copy yapmamızı sağlar
             * 
             */

            int a = 5;
            ref int b = ref a; // iki değişken üzerinde yapılan herhangi bir değişiklik, bellek üzerine yansıyacaktır.
            Console.WriteLine(a);
            Console.WriteLine(b);

            a *= 5;

            Console.WriteLine(b);

            b -= 10;
            Console.WriteLine(a);

            #region Örnek-1

            //int y = 10;
            //X(y); 
            //Console.WriteLine(y); //Değerini gönderdiğimiz için çıktıda 10 yazacaktır.
            int y = 10;
            X(ref y);
            Console.WriteLine(y); //Referansını gönderdiğimiz için çıktıda metottaki değer neyse onu baz alarak yazdıracaktır.

            void X(ref int x)
            {
                x = 25;


            }

            #endregion

            #endregion
            #region Ref Returns
            /* Sadece metotlarda kullanılmaktadır.
             * Metotlar geriye döndürülebilen yapılardır. Sadece değer değil, nesneleri ve değer türlü değişkenlerin
             *  referanslarını da geriye döndürebilirler.
             * 
             */
            #region Örnek-1

            int number1 = 5;
            int number2 = Z(ref number1);
            Console.WriteLine(number1);
            Console.WriteLine(number2);

            ref int Z(ref int y)
            {
                y = 25;
                return ref y;
            }
            #endregion
            #endregion
        }
    }
}
