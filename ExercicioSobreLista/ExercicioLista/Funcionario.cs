using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioLista {
    class Funcionario {

        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Funcionario(int id, string nome, double salario) {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void IncrementarSalario(double porc) {
            Salario += (Salario * (porc / 100.0));
            Console.WriteLine("Salário atualizado!");
        }

        public override string ToString() {
            return $"Id do funcionário: {Id} | Nome do funcionário: {Nome} | Salário do funcionário: R${Salario}";
        }
    }
}
