using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variavel
            int senha;

            //Entrada 
            senha = int.Parse(Console.ReadLine());

            //processamento / saida

            while (senha != 2002)
            {
                Console.WriteLine("Senha Invalida!");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido!");
        }
    }
}