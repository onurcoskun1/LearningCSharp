using System;

namespace ClassMembers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Field
            //Nesne içerisinde değer tutmamızı sağlayan alanlardır.

           /*Stack'teki m1 referansıyla, hype'deki nesneyi işaretleyecek */ MyClass m1= new MyClass(); //Hype'e gidecek nesneyi yerleştirir.

            MyClass m2= new MyClass(); // Nesne oluşturma işlemi
            m2.a = 25;
            m1.a  = 5;

            Console.WriteLine(m1.a); 
            #endregion
        }
    }


    class MyClass
    {
        public string b;
        public int a;
    }
}
