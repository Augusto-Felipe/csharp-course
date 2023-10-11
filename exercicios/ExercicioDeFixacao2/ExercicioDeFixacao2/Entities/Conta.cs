using System.Globalization;

namespace ExercicioDeFixacao2.Entities
{
    internal class Conta
    {
        public int Numero { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public Conta()
        {

        }

        public Conta(int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
            Saldo = 0.0;
        }

        public Conta(int numero, string nome, double saldo)
        {
            Numero = numero;
            Nome = nome;
            Saldo = saldo;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            Saldo -= valor;
        }

        public override string ToString()
        {
            return $"Conta {Numero}, "
                + $"Titular: {Nome}, "
                + $"Saldo: {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
