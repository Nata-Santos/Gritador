using System;

namespace Gritador
{
    class Program
    {
        static void Main(string[] args)
        {
            string grito;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Digite o que pensa e será exibido como grito");
            Console.WriteLine("--------------------------------------------");
            Console.ResetColor();
            
            Console.WriteLine();
            grito = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"{grito.ToUpper()}");


        
        }
    }
}
