// Assinatura de Metodo - Sobrecarga

var cadastro = new Cadastro();
var cliente = cadastro.Registrar();
cadastro.ExibirDados(cliente);

public class Cliente
{
    public string? Nome;
    public int Idade;
    public decimal Renda;

    public Cliente()
    { }
    public Cliente(string? nome, int idade, decimal renda)
    {
        Nome = nome;
        Idade = idade;
        Renda = renda;
    }
}

public class Cadastro
{
    public Cliente Registrar()
    {
        Cliente cliente = new Cliente("Joao", 23, 3000);
        return cliente;
    }
    public Cliente Registrar(Cliente cliente)
    {
        cliente.Renda = 3500;
        return cliente;
    }
    public void ExibirDados(Cliente cliente)
    {
        Console.WriteLine($"{cliente.Nome} {cliente.Idade} {cliente.Renda}");
    }
    public void ExibirDados(string texto,Cliente cliente)
    {
        Console.WriteLine(texto);
        Console.WriteLine($"{cliente.Nome} {cliente.Idade} {cliente.Renda}");
    }
}

public class Email
{
    public void Enviar(string endereco)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine($"Assunto padrao");
    }
    public void Enviar(string endereco, string assunto)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine($"{assunto}");
    }
    public void Enviar(string endereco, decimal valor)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine($"Assunto comercial");
        Console.WriteLine($"{valor}");
    }
    public void Enviar(decimal valor, string endereco)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine($"Pagamento fornercedor");
        Console.WriteLine($"{valor}");
    }
}