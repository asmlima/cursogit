namespace Primeiro {
    class ContaBancaria {
        public int Conta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int conta, string titular) {
            Conta = conta;
            Titular = titular;
            Saldo = 0.00;
        }

        public ContaBancaria(int conta, string titular, double saldo) : this(conta, titular) {
            Saldo = saldo;
        }

        public void Deposito(double valor) {
            Saldo += valor;
        }

        public void Saque(double valor) {
            Saldo -= (valor + 5.00);
        }

        public override string ToString() {
            return ($"Conta {Conta.ToString()}, Titular: {Titular}, Saldo: R$ {Saldo.ToString("F2")}");
        }
    }
}
