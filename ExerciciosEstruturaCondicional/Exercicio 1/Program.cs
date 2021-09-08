using System;

namespace Exercicio_1 {
    class Program {
        static void Main(string[] args) {
            //Exercicio 1) Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
            //Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
            //ordem crescente ou decrescente.

            Console.Write("Afim de saber se os números são multiplos, digite DOIS NUMEROS(X e Y) respectivamente separados por um ESPAÇO: ");
            String[] numeros = Console.ReadLine().Split(' ');

            double x = double.Parse(numeros[0]);
            double y = double.Parse(numeros[1]);

            if (x % y == 0  || y % x == 0 ) {
                Console.WriteLine("São multiplos!");
            } else {
                Console.WriteLine("Não são multiplos!");
            }

        }
    }
}
