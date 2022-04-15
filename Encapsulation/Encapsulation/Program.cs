using System;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir nesnenin işlevini, sınıfın içerisinde tutacak şekilde kapsüllemek.

            Product necklace = new Product(); //Burada "kolye" nesnedir.
            
            //necklace.Price = 10;
            //Kolyenin fiyat girişi yapılırken - fiyat girişi yapamayız.
            //Bunu denetlemek için tek yapılı bir "if" şartlı yapısı da kullanabiliriz fakat bütün uygulamada
            //sadece bir yerden ürün girişi yapılmayacağı ve bir yerin denetlenmeyeceği için bu şartın class ın içinde tanımlı olması lazım. (çamaşır makinesi RPM örneği gibi)
            necklace.SetPrice(10);

            necklace.Name = "Art-1";

            necklace.StockCount = 1000; //Stock sayısını direkt atadık. Prop kullanarak ve encapsulation uygulayarak.
            


        }
    }
}
