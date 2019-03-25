using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Elabore um programa que peça ao usuário seu nº preferido e depois o exiba.//

            Console.WriteLine("Digite seu numero predileto: ");
            float numero = float.Parse(Console.ReadLine());
            Console.WriteLine("O número digitado por voce foi: " + numero);
            Console.ReadKey();
        }
    }
}
