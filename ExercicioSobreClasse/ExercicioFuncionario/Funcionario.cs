using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFuncionario {
    class Funcionario {

        public string nome;
        public double salarioBruto;
        public double imposto;

        public void AumentaSalario(double porc) {
            salarioBruto += salarioBruto * (porc / 100.0);
        }

        public override string ToString() {
            return $"Funcionário: {nome} | Salário Bruto: R${salarioBruto} | Imposto: R${imposto}";
        }
    }
}
