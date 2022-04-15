using System;
using System.Collections.Generic;
using System.Linq;

namespace UsingDelegate
{
    internal class Program
    {
        static List<int> numbers = new List<int> {1,2,3, 4, 5, 6, 7, 8, 9, 10};
        static void Main(string[] args)
        {
            //Diyelim ki sayıları filtrelemek istiyoruz. (Çift sayılar, tek sayılar vb.)    

            //.NET 1.0 sisteminde durum bu
            //var filtered = Filter.filter(numbers,isMultiply3);

            //.NET 2.0 sisteminde durum bu
            var filtered = Filter.filter(numbers, delegate (int i) { return i < 5; });

            //.NET 3.5 sisteminden sonra olan durum:
            var filtered2 = Filter.filter(numbers, c => c < 5);

            //foreach (var item in filtered)
            //{
            //    Console.WriteLine(item);
            //}

            filtered2.ForEach(n=> Console.WriteLine(n));

            filtered.Where(x => x % 2 == 0);
        }

        //static List<int> filter(List<int> values)
        //{
        //    List<int> filtered = new List<int>();
        //    foreach (var item in values)
        //    {
        //        if (isMultiply3(item))
        //        {
        //            filtered.Add(item);
        //        }
        //    }

        //    return filtered;
        //}

        static bool isEven(int item)
        {
            return item % 2 == 0;
        }

        static bool isMultiply3(int item)
        {
            return item % 3 == 0;
        }
    }
}
