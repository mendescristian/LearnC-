using System;

namespace BancoDoCristian {
    class Program {
        static void Main(string[] args) {


            Conta conta;
            Console.WriteLine("----------------Banco do Cristian------------------");

            Console.Write("Digite o número da conta: ");
            int numConta = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome do titular da conta: ");
            string nomeTit = Console.ReadLine();
            Console.Write("Haverá depósito inicial? [S/N]: " );
            char havDepos = char.Parse(Console.ReadLine());
            

            if (havDepos == 'S' || havDepos == 's') {
                Console.Write("Digite o valor de depósito: R$");
                double deposInicial = double.Parse(Console.ReadLine());

                conta = new Conta(numConta, deposInicial, nomeTit);
            } else {
                conta = new Conta(numConta, nomeTit);
            }

            Console.WriteLine("--------Dados da conta-------");
            Console.WriteLine(conta);

            Console.Write("Entre um valor para depósito: R$");
            double valor = double.Parse(Console.ReadLine());
            conta.Deposita(valor);

            Console.WriteLine("--------Dados da conta-------");
            Console.WriteLine(conta);

            Console.Write("Entre um valor para saque: R$");
            valor = double.Parse(Console.ReadLine());
            conta.Saca(valor);

            Console.WriteLine("--------Dados da conta-------");
            Console.WriteLine(conta);



        }
    }
}
