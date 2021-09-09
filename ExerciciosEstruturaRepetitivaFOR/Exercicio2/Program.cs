using System;

namespace Exercicio2 {
    class Program {
        static void Main(string[] args) {
            //Exercicio 2) Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas,
            //começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme
            //exemplo.

            Console.Write("Digite um limite de números:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                int qd1 = (int) Math.Pow(i , 2);
                int qd2 = (int)Math.Pow(i, 3);
                Console.WriteLine($"{i} ao quadrado = {qd1} e ao cubo = {qd2}");

            }

        }
    }
}
