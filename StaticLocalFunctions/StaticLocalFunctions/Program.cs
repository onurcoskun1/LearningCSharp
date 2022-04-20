using System;

namespace StaticLocalFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        public void X(int a)   // Bu sistemin maliyeti 
        {
            int b = 0;

            static void Y(int a, int b) //Değişkenler içeriden erişilemez. Erişimlesi için parametre tanımlanması gerekir.
            {
                Console.WriteLine(a);
                Console.WriteLine(b);
            }

            Y(a, b);
        }
    }
}
