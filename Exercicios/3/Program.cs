using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao Programa de Validação de informações!");

            int validador = 0;
            int error = 0;
            string vazio = "";

            while (validador == 0)
            {
                Console.WriteLine("Digite o seu nome");
                string nomeUsuario = Console.ReadLine();

                if (nomeUsuario == vazio)
                {
                    error = error + 1;
                }

                Console.WriteLine("Digite a sua idade {entre 0 e 100 anos}");
                int idade = int.Parse(Console.ReadLine());

                if (idade! > 0 || idade! <= 100)
                {
                    error = error + 3;
                }

                Console.WriteLine("Digite o seu salário {maior que zero}");
                int salario = int.Parse(Console.ReadLine());
                if (salario > 0)
                {
                }
                else
                {
                    error = error + 5;
                }

                Console.WriteLine("Digite o seu Estado Civil (s/solteiro), (c/casado), (v/viuvo) ");
                string estadoCivil = Console.ReadLine().ToLower().Substring(0, 1);

                switch (estadoCivil)
                {
                    case "c":
                        estadoCivil = "casado(a)";
                        break;
                    case "s":
                        estadoCivil = "solteiro(a)";
                        break;
                    case "v":
                        estadoCivil = "Viúvo(a)";
                        break;
                    default:
                        error = error + 7;
                        break;
                }

                if (error == 0)
                {
                    validador = 2;
                    Console.WriteLine("\nSeu cadastro foi concluido!!! \nSuas Informações são:\n \nNome: " + nomeUsuario + "\nIdade: " + idade + "\nSalário: " + salario + " Reais" + "\nEstado Civil: " + estadoCivil);
                }
                else
                {
                    validador = 1;
                }
            }

            while (validador == 1)
            {

                switch (error)
                {
                    case 1:
                        Console.WriteLine("O campo Nome, não pode estar vazio!" + "\n Digite o seu nome corretamente:");
                        string nomeUsuario = Console.ReadLine();

                        if (nomeUsuario == vazio)
                        {
                        }
                        else
                        {
                            error = 0;
                        }
                        break;

                    case 3:
                        Console.WriteLine("Sua idade tem que estar entre a faixa (1 a 100 anos)!" + "\n Digite corretamente a sua idade:");
                        int idade = int.Parse(Console.ReadLine());
                        while (error == 3)
                        {
                        if (idade !<= 0 || idade !> 100)
                        {
                            error = 0;
                        }
                        else
                        {
                            error = 3;
                        }
                        }
                        break;

                    case 5:
                        Console.WriteLine("Seu Salário deve ser maior do que 0 (ZERO) reais!" + "\n para continuar, digite corretamente o seu salário atual:");
                        int salario = int.Parse(Console.ReadLine());
                        if (salario > 0)
                        {
                            error = 0;
                        }
                        break;

                    case 7:
                        Console.WriteLine("O seu estado civil deve ser um dos exemplos:" + "\n (s/solteiro), (c/casado), (v/viuvo)!");
                        string estadoCivil = Console.ReadLine().ToLower().Substring(0, 1);

                        switch (estadoCivil)
                        {
                            case "c":
                                error = 0;
                                break;
                            case "s":
                                error = 0;
                                break;
                            case "v":
                                error = 0;
                                break;
                        }
                        break;

                    case 4:
                        while (error == 4)
                        {
                            Console.WriteLine("Seu nome e sua Idade estão incorretos" + "\n Digite-os novamente seguindo os padrões!");
                            Console.WriteLine("Digite o seu nome");
                            string nomeUsuario1 = Console.ReadLine();
                            Console.WriteLine("Sua idade tem que estar entre a faixa (1 a 100 anos)!" + "/n Digite corretamente a sua idade:");
                            int idade1 = int.Parse(Console.ReadLine());

                            if (nomeUsuario1 == vazio && idade1! >= 0 || idade1! <= 100)
                            {
                            }
                            else
                            {
                                error = 0;
                            }
                        }
                        break;
                    case 9:
                        Console.WriteLine("Seu Nome, Sua Idade, e seu salário estão incorretos!" + "\n Digite-os novamente corretamente!");
                        Console.WriteLine("Digite seu Nome: ");
                        string nome2 = Console.ReadLine();
                        Console.WriteLine("Digite sua idade");
                        int idade2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite seu salário");
                        int salario2 = int.Parse(Console.ReadLine());

                        if (nome2 == vazio && idade2! >= 0 || idade2! <= 100 && salario2 == 0)
                        {
                        }
                        else
                        {
                            error = 0;
                            validador = 2;
                        }
                        break;
                }
            }
        }
    }
}