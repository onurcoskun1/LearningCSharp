using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    public class Cooker
    {
        public void Cook(Food food)
        {
            food.Cook();
        }
    }

    public class Food
    {
        public List<string> Ingredients { get; set; }

        public int Duration { get; set; }

        public void Cook()
        {
            Console.WriteLine("Yemek Pişiyor");
        }
    }

    public class VegitableFood : Food
    {

    }

    public class KuruFasulye : VegitableFood
    {

    }

    public class Kofte : Food
    {

    }

    
}
