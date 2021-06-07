using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("____Exercício 8 - Testando Condicionais____ \r\n \r\n");

            int idade = 16;
            int quantidadePessoas = 2;

            Console.WriteLine("* Testando Condicionais com OU \r\n");

            if (idade >= 18 || quantidadePessoas >= 2)
            {
                Console.WriteLine("Você possui 18 anos ou está acompanhado, por isso pode entrar.");
                Console.WriteLine("Seja bem vindo(a)! \r\n");
            }
            else
            {
                Console.WriteLine("Você NÃO possui 18 anos e NÃO está acompanhado, por isso NÃO pode entrar.");
            }

            Console.WriteLine("____________________________________________________ \r\n \r\n");

            int idade2 = 18;
            int quantidadePessoas2 = 2;

            Console.WriteLine("* Testando Condicionais com E \r\n");

            if (idade2 >= 18 && quantidadePessoas2 >= 2)
            {
                Console.WriteLine("Você possui 18 anos e está acompanhado, por isso pode entrar.");
                Console.WriteLine("Seja bem vindo(a)!");
            }
            else
            {
                Console.WriteLine("Você NÃO possui 18 anos ou NÃO está acompanhado, por isso NÃO pode entrar. \r\n \r\n");
            }

            Console.WriteLine("____________________________________________________ \r\n \r\n");

            int quantidadePessoas3 = 2;
            bool acompanhado = quantidadePessoas3 >= 2;

            Console.WriteLine("* Testando Condicionais com E, TRUE e FALSE \r\n");

            if (idade2 >= 18 && acompanhado == true)
            {
                Console.WriteLine("Você possui 18 anos e está acompanhado, por isso pode entrar.");
                Console.WriteLine("Seja bem vindo(a)!");
            }
            else
            {
                Console.WriteLine("Você NÃO possui 18 anos ou NÃO está acompanhado, por isso NÃO pode entrar. \r\n \r\n");
            }

            Console.ReadLine();
        }
    }
}