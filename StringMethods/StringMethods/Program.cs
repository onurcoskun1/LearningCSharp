using System;

namespace StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string metin = "Jugemu Jugemu Goko No Surikire Kaijarisuigyo no Suigyomatsu Unraimatsu Furaimatsu Ku Neru Tokoro ni Sumu Tokoro Yabura Koji no Bura Koji";
            //for (int i = 0; i < metin.Length; i++)
            //{
            //    if(metin[i] == 'o')
            //        Console.WriteLine(i);
            //}

            //int i = 0;
            //do
            //{
            //    if (metin[i] == 'o')
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //} while (i<metin.Length);

            #region + Operatörü
            //+ Operatörü, iki string ifade arasında birleştirme işlemini gerçekleştirmektedir.
            //Bir string ifade ile herhangi bir tür + operatörüyle işleme tabi tutulabilir.
            // + operatörü, farklı türlerle işleme koyulduğunda object + string davranışını sergiler ve sonuç olarak string değer döndürür.


            string a = "Merhaba";
            string b = "Dünya";

            Console.WriteLine(a+b);

            #endregion
            #region Formatlandırma
            string isim = "Onur", soyisim = "Coşkun", tcNo = "12345678910";
            int yas = 29;
            bool medeniHal = false;


            #region + Operatörü ile Formatlandırma
            //Bu formatlama işleminde ternary (?) operatörü ile kullanacaksak parantez içine almamız gerekir!
            //+ Operatörü hem kod hem de performans açısından oldukça maaliyetlidir. Bu yüzden tercih EDİLMEZ!

            Console.WriteLine($"TC No: " + tcNo + " " + "olan" + " " + isim + " " + soyisim + " " + "şahsın bilgileri | Yaş : " + yas + " " + "Medeni Hal: " + (medeniHal ? "Evli" : "Bekar"));


            #endregion

            #region string.Format Fonksiyonu
            Console.WriteLine("TC No: {0} olan {1} {2} şahsın bilgileri | Yaş : {3} Medeni Hal: {4}", tcNo , isim, soyisim, yas, medeniHal ? "Evli" : "Bekar");


            #endregion
            #region Interpolation
            Console.WriteLine($"TC No: {tcNo} olan {isim} {soyisim} şahsın bilgileri | Yaş : {yas} Medeni Hal: {(medeniHal ? "Evli" : "Bekar")}");

            #endregion
            #endregion
            #region String Kaçış(Escape) Karakterleri

            //", eylemsel bir karakterdir. Dolayısıyla böyle bir karakteri metinin içerisinde salt  bir şekilde kullanmamız mümkün değildir.
            //String için eylemsel ifade eden bir karakteri, metinsel olarak kullanacaksak; o karakterin o anlık özel karakter olmadığını ifade etmem gerekir. Bunu KAÇIŞ KARAKTERLERİ sağlar.

            // String içerisinde kaçış karakteri olarak "\" kullanılır. String içerisinde özel operatif karakterkleri ezen ve metinsel hale getirmemizi sağlayan bir karakterdir.
            //Kendisinden sonra gelen karakterin, bir operatif karakter olmadığını, metinsel bir değer olduğunu belirtir.
            Console.WriteLine("\"Bugün Hava Çok Güzel\"");

            //"\" yanıına illaki özel bir karakter ister. Bu ifadeyi metinsel olarak kullanmak istiyorsak, ilgili operatörü yine kendisiyle ezmemiz gerekir.
            Console.WriteLine("Seyhan\\ADANA");
            Console.WriteLine("\a"); //Bip(windows uyarı) sesi
            Console.WriteLine("abc\b"); //Kendisinden önceki ifadeyi siler
            Console.WriteLine("İsim\tSoyisim\tYaş"); //kolun oluşturmak için TAB tuşu gibi davranır.
            Console.WriteLine("Onur\nCoşkun"); //Alt satıra geçişi sağlar.


            #endregion
            #region @ Verbatim string operatörü
            #region 1. Kullanım
            //Bir değişken yahut metot gibi yapılanma isimlerinin bir keyword'e karşılık gelmesi mümkün değildir.
            //Eğer bu isimlerden birini kullanmak istiyorsak, @ operatörü ile bunu sağlayabiliriz.

            string @void = "Deneme";

            #endregion
            #region 2. Kullanım
            //Kaçış karakterlerinin kullanılması gereken durumlar
            //Eğer ifadenin başına @ operatörü kullanırsak, kullanmak istediğimiz eylemsel karakteri kendileri ile ezebiliyoruz.
            string metin = @"Hava Çok ""Güzel""";
            #endregion
            #region 3. Kullanım
            //Metinsel ifadelerde "" arasındaki ifadeler tek satırda yazılmak zorundadır. Compiler hata verecektir (+ operatörü ekler)
            string metin1 = @"asasdasd 
                asfafs 
                asfasf";
            #endregion
            #endregion
            #region Interpolution ve @ operatörünün birlikte kullanımı
            //@ operatörlü çıktılarda kaçış operatörleri bir anlam ifade etmemektedir.
            string siparisNo = "123654";
            int fiyat = 150;

            string mailMessage =
@$"Merhaba {isim} {soyisim}
{siparisNo} nolu sipariş talebiniz tafamıza iletilmiştir.
Fiyat = {fiyat}";

            Console.WriteLine(mailMessage);

            #endregion
        }
    }
}
