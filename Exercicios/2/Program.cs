using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-Vindo ao Programa de cadastro!");
            Console.WriteLine("Digite o seu Nome de Usuário:");
            string nome = Console.ReadLine();

           var validador = 1;

           while (validador == 1)
           {
               Console.WriteLine("Digite a sua senha: ");
               string senha = Console.ReadLine();

               if (senha == nome)
               { 
                   Console.WriteLine("Seu nome de Usuário não pode ser igual a sua senha!");
                   validador = 2;
               } else {
                   Console.WriteLine("Seu Nome e senha foram armazenados com sucesso!");
                   validador = 3;
               }
           }

           while (validador == 2)
           {
               Console.WriteLine("Digite a sua senha novamente: ");
               string senha = Console.ReadLine();

               if (senha == nome)
               { 
                   Console.WriteLine("Seu nome de Usuário não pode ser igual a sua senha!");
               } else {
                   Console.WriteLine("Seu Nome e senha foram armazenados com sucesso!");
                   validador = 3;
               }
           }
        }   
    }
}
