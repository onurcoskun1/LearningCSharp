using Microsoft.Extensions;
using Microsoft.Extensions.Primitives;
using System;
using System.Text;

namespace Dizilerde_Verisel_Performans
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            //int[] numbers2 = numbers[2..5];
            #region ArraySegment
            //Bir dizinin belirli bir kısmına ihtiyaç halinde, kopyalamak(oldukça maliyetlidir) yerine bağımsız bir referans
            //ile erişmemizi ve böylece salt bir şekilde temsil etmemizi sağlayan yapıdır.

            //ArraySegment<int> segment1 = new ArraySegment<int>(numbers); //Dizinin tüm elemanlarını temsil eder.

            //ArraySegment<int> segment2 = new ArraySegment<int>(numbers, 2, 5); //2. index'ten 5. index'e kadar tutar

            //segment1[0] *= 10;
            //segment2[0] *= 10;

            #endregion
            #region Array Slicing(Dilimleme)
            //Bir dizi üzerinde birden fazla parça/kısım ile çalışılacaksa eğer, her bir parçayı ayrı ayrı ArraySegment olarak tanımlayabiliriz.
            //Bu tanımlamaların dışında diziyi tek bir ArraySegment ile referans edip, ilgili parçaları o segment üzerinden çağırabiliriz.
            //Bu durumda yazılımsal açıdan efektiflik kazanmış oluruz.

            //ArraySegment<int> segment = new ArraySegment<int>(numbers);
            //ArraySegment<int> segment1 =segment.Slice(0, 3);
            #endregion

            #region StringSegment
            //ArraySegment ile aynı işlevi gören ve string değerler üzerinde çalışan özelleştirilmiş yapıdır.
            //Metinsel değerlerdeki birçok analitik operasyonlardan bizleri kurtaran ve Substring vb. fonksiyonlar yerine,
            //string değerde hedef kesit üzerinde işlem yapmamızı sağlayan bir türdür.

            string text = "Ölüme gidelim dedin de mazot mu yok dedik?";

            //String segmen türünü kullanabilmek için uygulamaya Microsoft.Extensions.Primitives paketinin yüklenmesi gerekmektedir.
            //StringSegment segment = new StringSegment(text);
            //StringSegment segment1 = new StringSegment(text, 2, 5);
            //Console.WriteLine(segment1);

            #endregion

            #region StringBuilder
            string name = "Onur";
            string surname = "COŞKUN";

            Console.WriteLine(name + " " + surname); //Maliyet yüksek kullanım

            //String birleştirme operasyonlarında + operatörüne nazaran yüksek maliyeti sönümlemek için arka planda,
            //StringSegment algoritmasını kullanarak, değerleri en az maliyetle birleştiren bir sınıftır.

            StringBuilder builder= new StringBuilder();
            builder.Append(name);
            builder.Append(" ");
            builder.Append(surname);
            Console.WriteLine(builder.ToString());
            #endregion
        }
    }
}
