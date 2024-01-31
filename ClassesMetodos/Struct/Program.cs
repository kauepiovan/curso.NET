// structs

Cliente cliente = new Cliente("maria", 20);

Console.WriteLine(cliente.Nome);
Console.WriteLine(cliente.Idade);

public struct Cliente
{
    public string? Nome { get; set; }
    public int Idade { get; set; }

    public Cliente(string? nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}