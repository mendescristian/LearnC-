using System;

namespace Exercicio3 {
    class Program {
        static void Main(string[] args) {
            //Exercicio 3) Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
            //código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.

            Console.Write("Digite respectivamente, separado por espaços o CÓDIGO DA PEÇA, QUANTIDADE DE PEÇAS E VALOR UNITÁRIO: ");
            String[] peca1 = Console.ReadLine().Split(' ');
            int cp1 = int.Parse(peca1[0]);
            int qt1 = int.Parse(peca1[1]);
            double valoru1 = double.Parse(peca1[2]);
            double valor1 = qt1 * valoru1;

            Console.Write("Digite respectivamente, separado por espaços o CÓDIGO DA PEÇA, QUANTIDADE DE PEÇAS E VALOR UNITÁRIO: ");
            String[] peca2 = Console.ReadLine().Split(' ');
            int cp2 = int.Parse(peca2[0]);
            int qt2 = int.Parse(peca2[1]);
            double valoru2 = double.Parse(peca2[2]);
            double valor2 = qt2 * valoru2;

            double valorfinal = valor1 + valor2;

            Console.WriteLine($"Valor total da peça código {cp1}: R${valor1:f2} ");
            Console.WriteLine($"Valor total da peça código {cp2}: R${valor2:f2}");
            Console.WriteLine($"Valor Final: R$ {valorfinal:F2}");


           



        }
    }
}
