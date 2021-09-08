using System;

namespace Exercicio2 {
    class Program {
        static void Main(string[] args) {
            //Exercicio 2) Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
            //casas decimais conforme exemplos.

            double pi = 3.14159;

            Console.Write("Digite o RAIO do circulo para descobrir sua área: ");
            double raio = double.Parse(Console.ReadLine());

            double resultado = pi * (Math.Pow(raio, 2));

            Console.WriteLine($"A área do circulo é: {resultado:F4}");


        }
    }
}
