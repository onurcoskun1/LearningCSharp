using System;

namespace StringFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region String Fonksiyonları
            string metin = "Kawaii desu ka?.";
            #region Contains
            //Bir metinsel ifadenin içerisinde herhangi bir değer olup/olmadığını kontrol eden fonksiyondur.

            bool sonuc = metin.Contains("desu");
            Console.WriteLine(sonuc);
            #endregion
            #region StartWith
            Console.WriteLine(metin.StartsWith("Kaw"));
            #endregion
            #region Equals
            //Elimizdeki metinsel ifade ile herhangi bir ifadenin değersel olarak eşit olup olmadığını kontrol eden yapıdır.
            Console.WriteLine(metin.Equals("mahmut"));
            Console.WriteLine(metin.Equals("Kawaii desu ka?."));
            #endregion
            #region Compare
            //Metinsel ifadeleri karşılaştırmamızı ve sonuç olarak int türünde değer elde etmemizi sağlayan yapıdır.
            //0, 1 veya -1 değerleri dönecektir.
            /* 0: Her iki değer de birbirine eşittir
             * 1: Soldaki sağdakinden alfa numerik olarak büyüktür
             *-1: Soldaki sağdakinden alfa numerik olarak küçüktür
             */

            Console.WriteLine(string.Compare(metin, "Z"));
            Console.WriteLine(string.Compare(metin, "A"));
            Console.WriteLine(string.Compare(metin, metin));

            Console.WriteLine(string.Compare(metin,9,metin,8,5));

            #endregion
            #region CompareTo
            //Compare ile aynı amaca hizmet eder ve aynı görevi gerçekleştirirler.
            //Kullanımı farklıdır. Bu sefer değer üzerinden yola çıkılır.

            Console.WriteLine(metin.CompareTo("Z"));
            Console.WriteLine(metin.CompareTo("A"));
            Console.WriteLine(metin.CompareTo(metin));
            #endregion
            #region IndexOf
            /*En önemli fonksiyonlardan birisidir.
             *Verilen değerin string ifade içerisinde olup olmadığını kontrol eden ve geriye index numarasını int türünde döndüren yapıdır.
             *Eğer eşleştirme söz konusu değilse "-1" değerini döndürür.
             *IndexOf fonksiyonu, metinde ilk eşleştiği değeri döndürür.
             */

            Console.WriteLine(metin.IndexOf("ka?"));
            Console.WriteLine(metin.IndexOf("de"));

            #endregion
            #region Insert
            //Elimizdeki metinsel ifadeye bir değer dahil etmemizi, eklememizi sağlayan fonksiyondur.
            //İşlem gerçekleştikten sonra oluşan string çıktısına ekleme gerçekleşir fakat işlem yapılan string ifadenin orijinal hali her zaman tutulur.

            string metinInsterted = metin.Insert(15, ".");
            Console.WriteLine(metinInsterted);
            Console.WriteLine(metin);
            #endregion
            #region Remove
            //Metinsel ifadede index olarak belirttiğimiz aralıktaki verileri silen bir fonksiyondur.
            //Orijinal veri Insert'deki gibi yine tutulur.

            Console.WriteLine(metin.Remove(5)); // 5. indexten sonrasını siler
            Console.WriteLine(metin.Remove(5,5)); //5. indexten sonraki 5 veriyi siler
            Console.WriteLine(metin);
            #endregion
            #region Replace
            //Elimizdeki metinsel ifadede belirtilen değerlerin ya da karakterlerin, belirtilen diğer değerler veya karakterler ile değiştirilmesini sağlayan bir fonksiyondur.
            Console.WriteLine(metin.Replace('a', 'A'));
            Console.WriteLine(metin.Replace("A", "a"));
            #endregion
            #region Split
            //Bir metinsel ifadeyi verilen değeri ayraç olarak kullanarak parçalayan ve sonucu "string dizisi" olarak döndüren fonksiyondur.
            string[] dizi = metin.Split(' ');
            string[] dizi2 = metin.Split(' ', 'a');
            #endregion
            #region Substring
            //Metinsel bir ifadenin belirli bir aralığını elde etmemizi sağlar.
            Console.WriteLine(metin.Substring(6)); //5. indexten sonuna kadar olan tüm değerleri string olarak bize döndürecektir.
            Console.WriteLine(metin.Substring(6,5)); //5. indexten sonraki 10 karakteri getirecektir.

            #endregion
            #region ToLower
            //Eldeki metinsel ifadenin tüm karakterlerini küçük karakterler olarak düzenler.
            Console.WriteLine(metin.ToLower());
            #endregion
            #region ToUpper
            //Eldeki metinsel ifadenin tüm karakterlerini küçük karakterler olarak düzenler.
            Console.WriteLine(metin.ToUpper());
            #endregion
            #region Trim
            //Girilen karakterin solunda veya sağında varsa boşlukları kaldıran fonksiyondur. 
            //İfadenin akışında olan boşluklara dokunmayacaktır.
            Console.WriteLine("   Onur COŞKUN   ".Trim());
            #endregion
            #region TrimEnd
            //İfadenin sadece sonundaki boşlukları kaldıracaktır.
            #endregion
            #region TrimStart
            //İfadenin sadece başındaki boşlukları kaldıracaktır.
            #endregion
            #endregion
        }
    }
}
