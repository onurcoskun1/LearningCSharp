using System;

namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Constructor: Oluşturucu demektir.
            //Bellekte HEAP alanında hangi özelliklerin oluşması gerektiğini veya adresi belirleyen kısmı "new" keywordü ile sağlarız.
            //Constructor ise, bellekte tanımlanacak nesnelerin varsayılan değerlerini saklamasını sağlar. Aksini belirtmediğimiz sürece class içerisinde bir varsayılan constructor vardır.

            Report report = new Report(); //Constructor "new" in yanına yazdığımız şey default constructor'dır.

            //report.CreatedDate = DateTime.Now;

            Console.WriteLine($"tarih : {report.CreatedDate}, format: {report.Format}, type: {report.Type}");

            Report performance = new Report("Onur");
            Console.WriteLine($"tarih : {performance.CreatedDate}, format: {performance.Format}, type: {performance.Type}, Raporu oluşturan: {performance.Owner}");
            Report customReport = new Report(Formats.Excel);

            Report costReport = new Report { Format= Formats.Excel, Type = "Maaliyet Raporu", Owner = "Onur COŞKUN" }

        }
    }
}
