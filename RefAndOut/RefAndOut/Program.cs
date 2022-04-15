using System;

namespace RefAndOut
{
    internal class Program
    {

        public enum Geometry
        {
            Square,
            Triangle,
            Circle,
            Rectangle
        }

        public enum TurkishManAffinity
        {
            Baba=1,
            Abi=2,
            Amca=4, //Bir insan hem baba hem abi olabilir. O yüzden Amca 3 olamaz.
            Dayi=8, //Yukarıdakilerin toplamı olmaması gerekiyor.
            Dede=16, //2^(n) olarak sayısal veriler verilmelidir. Çünkü toplamları veya herhangi bir kombinasyonları başka bir enum operasyona eşit olmaması gerekiyor.
        }

        static void Main(string[] args)
        {
            //int result = divide(12,3);
            //int outputValue = 0;
            //int result2 = divide(15,2, out outputValue);
            //Console.WriteLine($"Bölüm: {result}, kalan:{outputValue}");
            //int number = 8;
            //sample( ref number);
            //Console.WriteLine();

            //sum(14, 7, 15, 0, 23, 5, 9);

            Console.WriteLine($"3 birim kare: {getArea(3, "Ahmet")} ");
            Console.WriteLine($"4 birim daire: {getArea(4, "Circle")} ");
            Console.WriteLine($"4 ve 8 birim üçgen: {getArea(4, 8, "Triangle")} ");
            Console.WriteLine($"5 ve 9 birim dikdörtgen: {getArea(5, 9, "Rectangle")} ");


            //Alternatifi
            Console.WriteLine($"Örnek 1 Kare: {alternativeGetArea(15)}");
            Console.WriteLine($"Örnek 2 Daire: {alternativeGetArea(5,geometry:"Circle")}");
            Console.WriteLine($"Örnek 3 Kare: {alternativeGetArea(5,6,"Triangle")}");


            TurkishManAffinity affinity = TurkishManAffinity.Abi | TurkishManAffinity.Dayi;
        }

        //static int divide(int a, int b)
        //{
        //    return a / b;
        //}

        //static int divide(int a, int b, out int module)
        //{
        //    module = a % b;
        //    return a / b;
        //}

        //static void sample(ref int parameter)
        //{
        //    parameter *= 3;
        //    Console.WriteLine(parameter);
        //}

        //static int sum(params int[] numbers)
        //{
        //    int total = 0;
        //    foreach (int item in numbers)
        //    {
        //        total += item;
        //    }
        //    return total;
        //}


            

        /// <summary>
        /// get area for Circle or Square
        /// </summary>
        /// <param name="unit1Length"></param>
        /// <param name="geometry"></param>
        /// <returns></returns>
        static double getArea(int unit1Length, string geometry)
        {
            double calcValue = 0.0;
            switch (geometry)
            {
                case "Square":
                    calcValue = unit1Length * unit1Length;
                    break;
                case "Circle":
                    calcValue = (unit1Length * unit1Length) * Math.PI ;
                    break;
                default:
                    Console.WriteLine("You can calculate only Circle or Square area!");
                    break;
            }
            return calcValue;
        }
        /// <summary>
        /// get area for Triangle or Rectangle
        /// </summary>
        /// <param name="unit1Length"></param>
        /// <param name="unit2Length"></param>
        /// <param name="geometry"></param>
        /// <returns></returns>
        static double getArea(int unit1Length, int unit2Length, string geometry)
        {
            double calcValue = 0.0;
            switch (geometry)
            {
                case "Rectangle":
                    calcValue = unit1Length * unit2Length;
                    break;
                case "Triangle":
                    calcValue = (unit1Length * unit2Length) / 2;
                    break;
                default:
                    Console.WriteLine("You can calculate only Rectangle or Triangle area!");
                    break;
            }
            return calcValue;
        }
        
        static double alternativeGetArea(int unit1Length, int unit2Length = 1, string geometry = "Square")
        {
            double calcValue = 0.0;
            switch (geometry)
            {
                case "Square":
                    calcValue = unit1Length * unit1Length;
                    break;
                case "Circle":
                    calcValue = (unit1Length * unit1Length) * Math.PI;
                    break;
                case "Rectangle":
                    calcValue = unit1Length * unit2Length;
                    break;
                case "Triangle":
                    calcValue = (unit1Length * unit2Length) / 2;
                    break;
                default:
                    Console.WriteLine("You can calculate only Rectangle, Triangle,  area!");
                    break;

            }
            return calcValue;
        }

        static void alternativeAreaWithEnum(Geometry geometry)
        {
            double returnValue = 0;
            switch (geometry)
            {
                case Geometry.Square:
                    break;
                case Geometry.Triangle:
                    break;
                case Geometry.Circle:
                    break;
                case Geometry.Rectangle:
                    break;
                default:
                    break;
            }
        }
    }
}
