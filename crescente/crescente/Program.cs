using System;
using System.Globalization;
namespace retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int x, y;

            Console.WriteLine("Digite dois numeros: ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            while (x != y)
            {
                if ( x < y)
                {
                    Console.WriteLine("CRESCENTE!");
                }
                else
                {
                    Console.WriteLine("DECRESCENTE!");
                }
                    Console.WriteLine("Digite outro dois numeros: ");
                    x = int.Parse(Console.ReadLine());
                    y = int.Parse(Console.ReadLine());
            }


        }
    }
}