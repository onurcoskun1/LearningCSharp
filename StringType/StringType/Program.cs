using System;

namespace StringType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region String
            //Referans türlü olduğu halde programlama dilinde bir keyword barındıran tek değerdir.
            #region Null ve Empty arasındaki farklar
            #region Null & Empty
            //Bir değişken eğer "null" alıyorsa, bu durum, değişkenin herhangi bir alanı olmadığı anlamına gelir.
            //Arsa da yok, yapı da yok.
            //Null olan bir değer üzerinde işlem yapmaya çalışırsak "Runtime Error" ile karşılaşırız, YAPAMAYIZ!

            int? a = null;

            #region Emtpy
            //Bir değişken eğer Emtpy ise, değişkenin değeri yoktur fakat belirli bir alan tanımlanmıştır.
            //Arsa var, yapı yok.
            #endregion
            #endregion

            #region IsNullOrEmpty
            //IsNullOrEmpty fonksiyonu, elimizdeki string ifadenin null veya empty olup olmadığı durumunu kontrol eder ve geriye bool sonuç döndürür.
            string x = "";

            //if (x != string.Empty && x is not null) //is not operatörü değilse (!=) operatörüne eş değerdir.
            //{
            //    //Operasyon
            //}

            //bool b = string.IsNullOrEmpty(x);

            //Console.WriteLine(b);

            ////Genel kullanım
            //if (!string.IsNullOrEmpty(x))
            //{
            //    //Operasyon
            //}
            #endregion
            #region IsNullOrWhiteSpace
            //Bazı string ifadeler null veya empty olmaz ama boşluktan oluşabilir. Bunun kontrolü için oluşturulmuş bir fonksiyondur.
            string y = "    ";
            string.IsNullOrWhiteSpace(x);

            #endregion

            #endregion


            #endregion
        }
    }
}
