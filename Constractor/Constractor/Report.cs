using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Report
    {
        public enum Formats
        {
            PDF,
            Excel

        }
        public string Owner { get; set; }
        public string Type { get; set; }
        public Formats Format { get; set; }

        public DateTime CreatedDate { get; set; }


        public Report()  //Method değildir.
        {
            CreatedDate = DateTime.Now;
            Format = Formats.Excel;
            Type = "Monthly Sales Report";
            Console.WriteLine("Rapor sınıfından instance alındı");
            
            //Rapor oluşturma işlemini gerçekleştirir gerçekleştirmez bu değerler otomatik olarak tanımlanacaktır.
        }

        public Report(string owner):this()
        {
            Owner = owner;
        }

        public Report(Formats format):this()
        {
            Format = format;
        }
    }
}
