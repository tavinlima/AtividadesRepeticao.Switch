using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n Sequência de Fibonacci!" + "\n");
            Console.ResetColor();

               int primeiroNumero = 0;
               int segundoNumero = 1;
               int sequencia;

           for (var fibonacci = 0; fibonacci <= 13; fibonacci++)
           {
                sequencia = primeiroNumero + segundoNumero;
                primeiroNumero = segundoNumero;
                segundoNumero = sequencia;

               Console.ForegroundColor = ConsoleColor.Yellow;
               Console.WriteLine("Números da sequência de Fibonacci: " + sequencia);
               Console.ResetColor();
           }
            

        }
    }
}
