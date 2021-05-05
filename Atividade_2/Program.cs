using System;

namespace Atividade_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool senhaValida = false;

            Console.WriteLine("Insira seu nome de usuário: ");
	        string nomeUsuario = Console.ReadLine();
            do
            {
	        
	        Console.WriteLine("Insira sua senha");
	        string senha = Console.ReadLine();
	        
	        if (senha == nomeUsuario){
	        Console.WriteLine("\n ERRO! Insira uma senha válida diferente do seu nome de usuário." + "\n");
	        } 
	        else {
	            Console.WriteLine("Cadastro completo! Tenha um ótimo dia :)");
	            senhaValida = true;
	        }
            } while (senhaValida == false);
	        }
        }
    }
