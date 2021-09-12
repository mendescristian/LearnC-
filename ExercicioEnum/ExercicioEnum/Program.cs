using ExercicioEnum.Entities;
using ExercicioEnum.Entities.Enums;
using System;

namespace ExercicioEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome do departamento: ");
            string departamento = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Entre com os dados do trabalhador: ");
            Console.Write("Nome: ");
            string nomeTrab = Console.ReadLine();
            Console.Write("Nível (Junior/Pleno/Senior): ");
            WorkerLevel nivel = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Salário Base: R$");
            double salarioBase = double.Parse(Console.ReadLine());

            Departament departament = new Departament(departamento);
            Worker worker = new Worker(nomeTrab, nivel, salarioBase, departament);

            Console.Write("Quantos contratos esse trabalhador possui? ");
            int numContratos = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numContratos; i++)
            {
                Console.WriteLine($"Insira os dados do #{i} contrato: ");
                Console.Write("Data(DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor por hora: R$");
                double valorPorHora = double.Parse(Console.ReadLine());
                Console.Write("Duração: ");
                int duracao = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valorPorHora, duracao);
                worker.AddContract(contract);
            }

            Console.WriteLine();
            Console.Write("Insira o mês e o ano para calcular o pagamento (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3, 4));
            Console.WriteLine($"Nome: {worker.Name}");
            Console.WriteLine($"Departamento: {worker.Departament.Name}");
            Console.WriteLine($"Pagamento correspondente a {monthAndYear}: R${worker.Income(year, month)}");
        }
    }
}
