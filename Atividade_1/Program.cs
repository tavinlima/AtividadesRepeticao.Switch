using System;

namespace Atividade_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool notaCerta = false;

            while (notaCerta == false)
            {
            Console.WriteLine("Olá! Insira uma nota de 0 a 10: ");
            int nota = int.Parse(Console.ReadLine());

            if (nota >= 0 && nota <= 10){
                Console.WriteLine("Número válido!");
                notaCerta = true;
            } else{
                Console.WriteLine("Por favor, insira um número válido.");
            }
                
            }

            
        }
    }
}
