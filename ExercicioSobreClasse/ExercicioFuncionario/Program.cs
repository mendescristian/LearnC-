using System;

namespace ExercicioFuncionario {
    class Program {
        static void Main(string[] args) {

            Funcionario funcionario = new Funcionario();
            Console.Write("Nome do Funcionário: ");
            funcionario.nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            funcionario.salarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            funcionario.imposto = double.Parse(Console.ReadLine());

            Console.WriteLine(funcionario);

            Console.Write("Você deseja aumentar o salário do funcionário? [S/N]: ");
            char escolha = char.Parse(Console.ReadLine());

            if (escolha == 'S') {
                Console.Write("Digite a porcentagem do aumento: ");
                funcionario.AumentaSalario(double.Parse(Console.ReadLine()));
            }

            Console.WriteLine(funcionario);
            Console.WriteLine("Obrigado pela preferencia!");


        }
    }
}
