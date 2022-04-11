using System;

namespace ExemploInterface.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculo c = new Calculo();
            c.somar(10, 15);
            c.subtrair(50, 18);
            Console.ReadLine();

        }
    }
}
