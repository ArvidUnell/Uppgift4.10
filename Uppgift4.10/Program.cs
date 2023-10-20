using System;
namespace Upgift4_10
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Hur många X per grupp?");
            byte nrX = byte.Parse(Console.ReadLine());

            Console.WriteLine("Hur många O per grupp?");
            byte nrO = byte.Parse(Console.ReadLine());

            Console.WriteLine("Hur många O-mönster per rad?");
            byte nrOmönster = byte.Parse(Console.ReadLine());

            Console.WriteLine("Hur många rader?");
            byte nrRad = byte.Parse(Console.ReadLine());


            for (int i = 0; i < nrRad; i++)
            {
                Console.WriteLine();

                for (int j = 0; j < nrOmönster; j++)
                {
                    for (int k = 0; k < nrX; k++)
                    {
                        Console.Write('X');
                    }
                    Console.Write('-');

                    for (int k = 0; k < nrO; k++)
                    {
                        Console.Write('O');
                    }
                    Console.Write('-');
                }

                for (int k = 0; k < nrX; k++)
                {
                    Console.Write('X');
                }
            }

            Console.WriteLine("\nTryck på valfri knapp för att avsluta");
            Console.ReadKey();
        }
    }
}