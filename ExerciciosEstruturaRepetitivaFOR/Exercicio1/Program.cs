using System;

namespace Exercicio1 {
    class Program {
        static void Main(string[] args) {
            //Exercicio 1) Leia um valor inteiro X(1 <= X <= 1000).Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o
            //X, se for o caso.

            Console.Write("Digite um número para saber quais são os números ímpares até ele: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++) {
                if ( i % 2 != 0) {
                    Console.WriteLine(i);
                }

            }

        }
    }
} 
