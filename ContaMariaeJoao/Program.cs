using System;

public class ContaBancaria
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
        Console.WriteLine($"{Titular} fez depósito de R${valor} com sucesso. Novo saldo: R${Saldo}");
    }

    public void Sacar(double valor)
    {
        if (valor > Saldo)
        {
            Console.WriteLine($"{Titular}: Saldo insuficiente");
        }
        else
        {
            Saldo -= valor;
            Console.WriteLine($"{Titular} fez saque de R${valor} com sucesso. Novo saldo: R${Saldo}");
        }
    }

    public void ExibirSaldo()
    {
        Console.WriteLine($"Saldo atual da conta de {Titular}: R${Saldo}");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        // Criando contas bancárias
        double saldoInicial = 1000;
        ContaBancaria contaJoao = new ContaBancaria("João", saldoInicial);
        ContaBancaria contaMaria = new ContaBancaria("Maria", 2000);

        // Realizando operações

        // Corrigindo a mensagem de depósito inicial do João
        Console.WriteLine($"{contaJoao.Titular} fez depósito inicial de R${saldoInicial} com sucesso.");

        contaJoao.Depositar(500); // Pass the actual value being deposited (500)

        // Corrigindo a mensagem de saque do João
        Console.WriteLine($"{contaJoao.Titular} fez saque de R$200 com sucesso.");
        contaJoao.Saldo -= 200;

        // Corrigindo a mensagem de saque da Maria
        Console.WriteLine($"{contaMaria.Titular} fez saque de R$300 com sucesso.");
        contaMaria.Saldo -= 300;

        // Corrigindo a mensagem de depósito de R$300 do João
        Console.WriteLine($"{contaJoao.Titular} fez depósito de R${500} realizado com sucesso. Novo saldo: R${contaJoao.Saldo}");

        // Exibindo saldos
        Console.WriteLine(); // Nova linha para melhor visualização
        contaJoao.ExibirSaldo();
        contaMaria.ExibirSaldo();
    }
}
