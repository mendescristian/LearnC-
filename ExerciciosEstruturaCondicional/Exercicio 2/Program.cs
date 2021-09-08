using System;

namespace Exercicio_2 {
    class Program {
        static void Main(string[] args) {
            //Exercicio 2) Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas
            //de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o
            //ponto, ou se está sobre um dos eixos cartesianos ou na origem(x = y = 0).
            //Se o ponto estiver na origem, escreva a mensagem “Origem”.
            //Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a
            //situação.

            Console.Write("Digite a coordenada 'x': ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Digite a coordenada 'y': ");
            double y = double.Parse(Console.ReadLine());

            if (x > 0.0 && y > 0.0) {
                Console.WriteLine("Quadrante: Q1");
            } else if (x < 0.0 && y > 0.0) {
                Console.WriteLine("Quadrante: Q2");
            } else if (x < 0.0 && y < 0.0) {
                Console.WriteLine("Quadrante: Q3");
            } else if (x > 0.0 && y < 0.0) {
                Console.WriteLine("Quadrante: Q4");
            } else {
                Console.WriteLine("Origem");
            }

        }
    }
}
