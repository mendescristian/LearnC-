using System;
using System.Collections.Generic;
using System.Text;

namespace BancoDoCristian {
    class Conta {

        public int NumeroConta { get; private set; }
        public double Saldo { get; private set; }
        public string Titular { get; set; }

        public Conta(int numeroConta, double saldo, string titular) {
            NumeroConta = numeroConta;
            Saldo = saldo;
            Titular = titular;
        }

        public Conta(int numeroConta, string titular) {
            NumeroConta = numeroConta;
            Titular = titular;
        }

        public void Deposita(double valor) {
            if (valor > 0.0) {
                Saldo += valor;
            } else {
                Console.WriteLine("O valor a ser depositado deverá ser maior que R$0,00");
            }
        }

        public void Saca(double valor) {
            if (valor > 0.0 || valor >= Saldo) {
                Saldo -= (valor + 5.0);
            } else {
                Console.WriteLine("O valor a ser sacado deverá ser maior que R$00,01 e menor que o saldo atual.");
            }
        }

        public override string ToString() {
            return $"Nome do Titular: {Titular} | Número da conta: {NumeroConta} | Saldo atual: R${Saldo:f2}";
        }

    }
}
