using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingDelegate
{
    public class Filter
    {

        //OOP sistemlerde bir nesnenin metodu başka bir nesnenin metodu içerisinde kullanılamaz. Bu yüzden delegate kullanılarak bu problem çözülür
        //public delegate bool Criteria(int item);
        
        //.NET 4.0
        /*void metotlara = action
         * değer döndürenlere = function
         */
        public static List<int> filter(List<int> values, Func<int, bool> criteria) //Function ve action kullanma işlemine generic delegate denir
        {
            List<int> filtered = new List<int>();
            foreach (var item in values)
            {
                if (criteria(item))
                {
                    filtered.Add(item);
                }
            }

            return filtered;
        }
    }
}
