using System;

namespace ExercicioEstruturaSequencial {
    class Program {
        static void Main(string[] args) {
            //Exercicio 1) Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
            //mensagem explicativa.

            Console.Write("Digite um numero: ");
            double numero1 = double.Parse(Console.ReadLine());

            Console.Write("Digite outro número: ");
            double numero2 = double.Parse(Console.ReadLine());

            double resultado = numero1 + numero2;
            Console.WriteLine($"A soma dos dois números é: {resultado}");
        }
    }
}
