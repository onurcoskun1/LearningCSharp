using System;

namespace StringExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Adımızın baştan 3. ve soyadımızın sondan 5. karakterini getiren yazılım
            //string nameSurname = "Onur COŞKUN";

            #region Çözüm

            //string answer = nameSurname[2..^4];
            //Console.WriteLine(answer[0]);
            //Console.WriteLine(answer[answer.Length-1]);
            #endregion
            #endregion

            #region Girilen metnin içerisinde kaç adet "n" karakterinin geçtiğini hesaplayan yazılım

            //Console.WriteLine("Lütfen bir metin giriniz: ");
            //string metin= Console.ReadLine();

            //int count = 0;
            //for (int i = 0; i < metin.Length; i++)
            //{
            //    if (metin[i] == 'n')
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            #endregion

            #region Girilen metindeki kelime sayısını hesaplayan yazılım
            Console.WriteLine("Lütfen bir metin giriniz :");
            string metin = Console.ReadLine();

            #region 1. Çözüm
            //string[] kelimeler = metin.Split(' ');
            //Console.WriteLine(kelimeler.Length);
            #endregion
            #region 2. Çözüm
            int count = 1;
            while (true)
            {
                int index= metin.IndexOf(' ');
                if (index == -1)
                    break;

                count++;
                metin = metin.Substring(index +1);
            }

            Console.WriteLine(count);
            #endregion

            #endregion
        }
    }
}
