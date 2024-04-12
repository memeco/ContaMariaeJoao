using System;

class ContaBancaria
{
    public string Titular;
    public double Saldo;

    public ContaBancaria(string titular, double saldoInicial)
    {
        Titular = titular;
        Saldo = saldoInicial;
    }

    public void Depositar(double valor)
    {
        Saldo += valor;
        Console.WriteLine($"Depósito de {valor} realizado com sucesso. Novo saldo: {Saldo}");
    }

    public void Sacar(double valor)
    {
        if (valor > Saldo)
        {
            Console.WriteLine("Saldo insuficiente");
        }
        else
        {
            Saldo -= valor;
            Console.WriteLine($"Saque de {valor} realizado com sucesso. Novo saldo: {Saldo}");
        }
    }
    public void ExibirSaldo()
    {
        Console.WriteLine($"Saldo atual da conta de {Titular}: {Saldo}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Criando uma conta bancária para João com saldo inicial de 1000
        ContaBancaria contaJoao = new ContaBancaria("João", 1000);

        // Realizando operações na conta de João
        contaJoao.Depositar(500);
        contaJoao.Sacar(200);
        contaJoao.ExibirSaldo();

        // Criando uma nova conta bancária para Maria com saldo inicial de 2000
        ContaBancaria contaMaria = new ContaBancaria("Maria", 2000);

        // Transferindo 300 da conta de Maria para a conta de João
        contaMaria.Sacar(300);
        contaJoao.Depositar(300);

        // Exibindo os saldos atualizados das contas
        contaJoao.ExibirSaldo();
        contaMaria.ExibirSaldo();

    }
}