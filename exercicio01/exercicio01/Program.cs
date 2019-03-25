using System;

namespace exercicio01
{
    class Program
    {
        static void Main(string[] args)

            //Faça um programa que leia nome, cod, valor e quantidade de uma peça e retorne seu codigo e seu valor total//
        {
            Console.WriteLine("Digite o nome da peça:");
            string nomePeca = Console.ReadLine();
            Console.WriteLine("Digite o código da peça:");
            int codPeca = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da peça:");
            float valorPeca = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de peças:");
            int qtaPeca = int.Parse(Console.ReadLine());

            float resultado = qtaPeca * valorPeca;
            Console.WriteLine("O código da sua peça é: " +codPeca+" e o Valor total das peças é: " +resultado);

            Console.ReadKey();
        }
    }
}
