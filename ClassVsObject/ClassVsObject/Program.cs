using System;

namespace ClassVsObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person trainer = new Person();
            trainer.Name = "Türkay";
            trainer.LastName = "Ürkmez";

            Person tester = new Person();
            tester.Name = "Onur";
            tester.LastName = "Coşkun";

            Person student1 = new Person();
            student1.Name = "Onur";

            Person student2 = student1;
            student2.Name = "İrem Ergin";

            Console.WriteLine(student1.Name);

            /*
             * Musteri musteri = new Musteri();
             * Yemek sandviç = new Yemek();
             * Sepet yemekSepeti = new Sepet();
             * yemekSepeti.Ekle(sandviç);
             * Musteri.SiparisVer(yemekSepeti);
             * 
             */



        }
    }
}
