using System;

namespace RefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //int number1;
            //int number2 = 20;
            //var result = Add( out number1 , number2);
            //Console.WriteLine("Sonuç : " + result);
            //Console.ReadLine();

            //static int Add(out int number1, int number2)
            //{
            //    number1 = 3; //eğer number1 tanımlanmamışsa number1  olarak varsayılacak sayı.
            //    return number1 + number2;
            //}

            int sayi1 = 4;
            int sayi2 = 8;
            var result2 = Multiply( sayi1 ,ref sayi2);
            Console.WriteLine("Sonuç : " + result2);
            Console.WriteLine(sayi2);
            Console.ReadLine();

            static int Multiply(int sayi1, ref int sayi2)
            {
                sayi2 = 4; //sayi2 ref olduğu için sayi2'yi bu değer olarak güncelleyecek.
                var result2 = sayi1 * sayi2;
                return result2;
            }
            
        }
    }
}
