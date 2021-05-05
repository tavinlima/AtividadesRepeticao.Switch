using System;

namespace Atividade_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool nomeValido = false;
            bool idadeValida = false;
            bool salarioValido = false;
            bool estadoCivilValido = false;

            //Inserir nome
            Console.WriteLine("Insira seu nome: ");
            string nome = Console.ReadLine();
            do
            {
                if (nome ! == ""){
                Console.WriteLine("Insira seu NOME: ");
                nome = Console.ReadLine();
            } else{
                nomeValido = true;
            }

            }while (nomeValido == false);
            //Fim Inserir Nome

            //Inserir Idade
            do
            {
            Console.WriteLine("Insira sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            if(idade > 0 && idade <= 150){
                idadeValida = true;
            } else{
                idadeValida = false;
            }    

            } while (idadeValida == false);
            //Fim inserir idade

            //Inserir o valor do salário
            do
            {
            Console.WriteLine("Insira o valor da sua média salarial: ");
            double salario = double.Parse(Console.ReadLine());

            if(salario > 0){
                salarioValido = true;
            } else{
                Console.WriteLine ("Valor inválido." + "\n");
            }
                
            } while (salarioValido == false);
            //Fim inserir salário

            //Inserir estado civil
            do
            {
            Console.WriteLine("Insira seu estado civil: ");
            Console.WriteLine("s para solteiro(a), c para casado(a), v para víuvo(a) ou d para divorciado(a)");
            string estadoCivil = Console.ReadLine() .ToLower();

            switch (estadoCivil)
            {
                case "s":
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine ("\n Operação finalizada, tenha um ótimo dia! :)" + "\n");
                Console.ResetColor();
                estadoCivilValido = true;
                    break;
                case "c":
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine ("\n Operação finalizada, tenha um ótimo dia! :)" + "\n");
                Console.ResetColor();
                estadoCivilValido = true;
                    break;
                case "v":
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine ("\n Operação finalizada, tenha um ótimo dia! :)" + "\n");
                Console.ResetColor();
                estadoCivilValido = true;
                    break;
                case "d":
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine ("\n Operação finalizada, tenha um ótimo dia! :)" + "\n");
                Console.ResetColor();
                estadoCivilValido = true;
                    break;
                default: 
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine ("Valor inválido." +"\n");
                Console.ResetColor();
                    break;
            }

            // if (estadoCivil == "s" || estadoCivil == "c" || estadoCivil == "v" || estadoCivil =="d"){
            //     estadoCivilValido = true;
            //     Console.ForegroundColor = ConsoleColor.DarkGreen;
            //     Console.WriteLine ("\n Operação finalizada, tenha um ótimo dia! :)" + "\n");
            //     Console.ResetColor();
            // } else{
            //     Console.ForegroundColor = ConsoleColor.DarkRed;
            //     Console.WriteLine ("Valor inválido." +"\n");
            //     Console.ResetColor();
            //     estadoCivilValido = false;
            // } 

            } while (estadoCivilValido == false);
            //Fim inserir Estado Civil
            

        }
    }
}
