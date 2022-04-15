using System;

namespace ArraySinifi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Array Sınıfı
            //Dizi olarak tanımlanan değişkenler, Array sınıfından türetilmektedir.
            //Dolayısıyla dizilerde Array sınıfından gelen belirli metotlar ve özellikler mevcuttur. 



            #region Array Türünden Dizilere Değer Atama / Okuma


            #region 1. Yöntem
            //int[] dizi = new int[3];
            //dizi[0] = 30;
            //dizi[1] = 31;
            //dizi[2] = 32;
            //Array dizi2 = dizi;

            #endregion
            #region 2. Yöntem
            //Array dizi = new int[] { 3, 5, 6, 7 };
            //Array dizi = new[] { 3, 5, 7, 9 };


            #endregion
            #region 3. Yöntem
            //Array dizi = new int[3];
            //dizi.SetValue(30, 0);
            //dizi.SetValue(31, 1);
            //dizi.SetValue(32, 2);

            //object value = dizi.GetValue(1);
            //Console.WriteLine(value);
            #endregion

            #region Metotlar
            #region Clear
            //Dizi içerisindeki tüm elemanlara, dizinin türüne uygun default değer ataması yapar.
            //Array isimler = new[] { "Onur", "Ümit", "Halit", "Devrim", "Ufuk" };


            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine(isimler.GetValue(i));
            //}
            //Array.Clear(isimler, 0, isimler.Length);
            //Console.WriteLine("************************");
            //for (int i = 0; i < isimler.Length; i++)
            //    Console.WriteLine(isimler.GetValue(i));
            //{

            //}
            #endregion
            #region Copy
            //Bir dizinin değerlerini bir başka diziye kopyalamamızı sağlayan bir fonksiyondur.
            Array isimler = new[] { "Onur", "Ümit", "Halit", "Devrim", "Ufuk" };

            //string[] isimler2 = new string [isimler.Length];

            //Array.Copy(isimler, isimler2 , isimler.Length);

            //for (int i = 0; i < isimler2.Length; i++)
            //    Console.WriteLine(isimler2[i]);

            //Array.Copy(isimler, 2, isimler2, 0, 2);
            //for (int i = 0; i < isimler2.Length; i++)
            //    Console.WriteLine(isimler2[i]);

            #endregion
            #region IndexOf
            //Dizi içerisinde bir elemanın var olup olmadığını sorgulayabildiğimiz fonksiyondur.
            //Arama sonucunda ilgili değer varsa, int olarak o değerin index numarasını döndürür.
            //Yoksa -1 döndürür.

            //int index = Array.IndexOf(isimler, "Ali");

            //if (index != -1)
            //{
            //    //Demek ki aranan değer ilgili dizide mevcuttur.
            //    Console.WriteLine("Var");
            //}

            //Array.IndexOf(isimler, "Onur", 0, 3);

            #endregion
            #region Reverse
            //Elimizdeki dizinin elemanlarını tersine sıralayan bir fonksiyondur.
            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine(isimler.GetValue(i));
            //}

            //Array.Reverse(isimler);

            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine(isimler.GetValue(i));
            //}

            //Array.Reverse(isimler, 0, 3);
            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine(isimler.GetValue(i));
            //}


            #endregion
            #region Sort
            //Elimizdeki dizinin küçükten büyüğe/A'dan Z'ye sıralama işlemini yapan fonksiyondur.

            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine(isimler.GetValue(i));
            //}

            //Array.Sort(isimler);
            //Console.WriteLine("*******************");

            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine(isimler.GetValue(i));
            //}
            #endregion
            #endregion
            #region Özellikler
            #region IsReadOnly
            //Bir dizinin salt okunabilir olup olmadığını kontrol eden ve sonuç olarak geriye bool değer dönen bir özelliktir.

            //Console.WriteLine(isimler.IsReadOnly);
            #endregion
            #region IsFixedSize
            //Bir dizinin boyutunun/eleman sayısının sabit olup olmadığını kontrol eden ve bool değer dönen bir özelliktir
            //Tüm temel dizilerde "true" dönecektir
            //Console.WriteLine(isimler.IsFixedSize);
            #endregion
            #region Length
            //Bir dizinin eleman sayısını verir
            //Console.WriteLine(isimler.Length);
            #endregion
            #region Rank
            //Bir dizinin derecesini geriye döndürür. 
            Console.WriteLine(isimler.Rank);
            int[,,] x = new int[3, 4, 5];
            Console.WriteLine(x.Rank);
            #endregion
            #endregion
            #endregion
            #endregion
        }
    }
}
