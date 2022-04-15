using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Product
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; } // buradaki value dışarıdan tanımlanan C# ın tanımlandığı varsayılan değerdir.
        }
       
        private double Price; //private yapınca artık Price objesi sadece sınıfa ait olur. Sadece içeride tanımlanır.

        /// <summary>
        /// VERİ YAZMA
        /// </summary>
        /// <param name="value"></param>
        /// <exception cref="ArgumentException"></exception>
        public void SetPrice(double value)
        {
            if (value > 0)
                Price = value;
            else
                throw new ArgumentException("You can not enter negative price..");
        }

        /// <summary>
        /// VERİ OKUMA
        /// </summary>
        /// <returns>Fiyatı döndürür ve okuma işlemini gerçekleştirir</returns>
        public double GetPrice()  
        {
            return Price;
        }

        private int stock;
        public int StockCount 
        {
            get
            {
                return stock;
            }
            set
            {
                if (value < 0)
                {
                    stock = 0;
                    IsProductFoundInStock = false;
                }
                    
            } }

        public bool IsProductFoundInStock { get; private set; } //ReadOnly'dir set edilemez.

        public double Discount { get; set; }
        public string Description { get; set; }
    }
}
