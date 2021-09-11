using System;
using System.Collections.Generic;

namespace ExercicioLista {
    class Program {
        static void Main(string[] args) {

            Console.Write("Quantos funcionários serão registrados? ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> lista = new List<Funcionario>();

            for (int i = 1; i <= n; i++) {
                Console.Write($"Id do funcionário #{i}: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write($"Nome do Funcionário #{i}: ");
                string nome = Console.ReadLine();
                Console.Write($"Salário do funcionário #{i}: R$");
                double salario = double.Parse(Console.ReadLine());

                lista.Add(new Funcionario(id, nome, salario));
            }

            Console.Write("Deseja visualizar a lista de funcionários? [S/N]: ");
            char respo = char.Parse(Console.ReadLine());
            Console.WriteLine();
            
            if(respo == 'S' || respo == 's') {
                Console.WriteLine("--------------------Lista de Funcionarios------------------");
                foreach (Funcionario func in lista) {
                    Console.WriteLine(func);
                }
                Console.WriteLine("-----------------------------------------------------------");
            }

            Console.Write("Deseja aumentar o salário de algum funcionário? [S/N]: ");
            char respAum = char.Parse(Console.ReadLine());
            if (respAum == 'S' || respAum == 's') {
                Console.Write("Digite o ID do funcionário desejado: ");
                int searchID = int.Parse(Console.ReadLine());
                Funcionario achaId = lista.Find(func => func.Id == searchID);
                if (achaId != null) {
                    Console.Write("Digite a porcentagem de aumento: ");
                    double porc = double.Parse(Console.ReadLine());
                    achaId.IncrementarSalario(porc);
                }

                Console.WriteLine("--------------------Lista de Funcionarios------------------");
                foreach (Funcionario func in lista) {
                    Console.WriteLine(func);
                }
                Console.WriteLine("-----------------------------------------------------------");


            }



        }
    }
}
