using System;

namespace Exercicio2 {
    class Program {
        static void Main(string[] args) {

            //Exercicio 2) Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
            //um algoritmo para ler o tipo de combustível abastecido(codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
            //4.Fim). Caso o usuário informe um código inválido(fora da faixa de 1 a 4) deve ser solicitado um novo código(até
            //que seja válido). O programa será encerrado quando o código informado for o número 4.Deve ser escrito a
            //mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustíve
          

            int gasolina = 0;
            int alcool = 0;
            int diesel = 0;

            Console.Write("Digite o combustível desejado (1 PARA GASOLINA | 2 PARA ALCOOL | 3 PARA DIESEL): ");
            int combustivel = int.Parse(Console.ReadLine());

            while (combustivel != 4) {
                if (combustivel == 1) {
                    ++gasolina;
                } else if (combustivel == 2) {
                    ++alcool;
                } else if (combustivel == 3) {
                    ++diesel;
                } else {
                    Console.WriteLine("Combustivel não identificado.");
                }

                Console.Write("Digite o combustível desejado (1 PARA GASOLINA | 2 PARA ALCOOL | 3 PARA DIESEL): ");
                combustivel = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Muito obrigado!");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Alcool: {alcool}");
            Console.WriteLine($"Diesel: {diesel}");




        }
    }
}
