using System;

namespace ExercicioDois
{
    class Program
    {
        static void Main(string[] args)
        {
            int anoatual, anonasc, resultado;
            Console.WriteLine("Informe o ano atual (Ex: 2020):");
            anoatual = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o ano de seu nascimento (Ex: 1998):");
            anonasc = int.Parse(Console.ReadLine());

            resultado = anoatual - anonasc;

            if (resultado >=18)
            {
                Console.WriteLine("O usuário tem {0} anos - É de maior", resultado);
            }
            else if (resultado <= -1)
            {
                Console.WriteLine("Idade inválida");
            }

            else
            {
                Console.WriteLine("O usuário tem {0} anos - Não é de maior", resultado);
            }

        }
    }
}
