using System;

class Pessoa
{
    public string Nome { get; set; }
    public int QuantidadeHospedes { get; set; }
}

class Suíte
{
    public int Numero { get; set; }
    public decimal ValorDiaria { get; set; }
}

class Reserva
{
    public Pessoa Hospede { get; set; }
    public Suíte Suite { get; set; }
    public int QuantidadeDias { get; set; }

    public decimal CalcularValorTotal()
    {
        decimal valorTotal = Suite.ValorDiaria * QuantidadeDias;

        if (QuantidadeDias > 10)
        {
            decimal desconto = valorTotal * 0.1m;
            valorTotal -= desconto;
        }

        return valorTotal;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Criando uma pessoa
        Pessoa pessoa = new Pessoa();
        pessoa.Nome = "João";
        pessoa.QuantidadeHospedes = 2;

        // Criando uma suíte
        Suíte suite = new Suíte();
        suite.Numero = 1;
        suite.ValorDiaria = 100;

        // Criando uma reserva
        Reserva reserva = new Reserva();
        reserva.Hospede = pessoa;
        reserva.Suite = suite;
        reserva.QuantidadeDias = 12;

        // Calculando o valor total da reserva
        decimal valorTotal = reserva.CalcularValorTotal();

        // Exibindo informações da reserva
        Console.WriteLine("Reserva para: " + reserva.Hospede.Nome);
        Console.WriteLine("Suíte número: " + reserva.Suite.Numero);
        Console.WriteLine("Quantidade de hóspedes: " + reserva.Hospede.QuantidadeHospedes);
        Console.WriteLine("Valor da diária: " + reserva.Suite.ValorDiaria.ToString("C"));
        Console.WriteLine("Quantidade de dias: " + reserva.QuantidadeDias);
        Console.WriteLine("Valor total da reserva: " + valorTotal.ToString("C"));
    }
}
