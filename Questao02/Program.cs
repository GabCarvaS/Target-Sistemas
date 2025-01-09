namespace Questao02
{
    using System;

    class Program
    {
        static void Main()
        {            
            Console.Write("Digite um número para verificar se pertence à sequência de Fibonacci: \n");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int numero))
                {
                    if (PertenceFibonacci(numero))
                    {
                        Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
                    }
                    else
                    {
                        Console.WriteLine($"{numero} NÃO pertence à sequência de Fibonacci.");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro.");
                }
            }
        }

        static bool PertenceFibonacci(int num)
        {           
            if (num == 0 || num == 1)
                return true;

            var a = 0;
            var b = 1;

            while (b < num)
            {
                int temp = b;
                b = a + b;
                a = temp;
            }
            
            return b == num;
        }
    }

}
