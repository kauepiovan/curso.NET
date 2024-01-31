var cliente = new Cliente("joao", "joao@email.com", 16);

Console.WriteLine("Sem passar o argumento de idade\n");
cliente.ExibirInfo("joao", "joao@email.com");
Console.WriteLine("Passando o argumento de idade\n");
cliente.ExibirInfo("joao", "joao@email.com", 35);

public struct Cliente
{
    public string Nome;
    public string Email;

    private int idade;
    public int Idade
    {
        get { return idade; }
        set
        {
            if (value <= 18)
            {
                idade = 18;
                Console.WriteLine("Idade menor que 18");
            }
            else
            {
                idade = value;
                Console.WriteLine("Idade maior que 18");
            }
        }
    }

    public Cliente(string nome, string email, int idade)
    {
        Nome = nome;
        Email = email;
        Idade = idade;
    }

    public void ExibirInfo(string nome, string email, int idade = 18)
    {
        Console.WriteLine($"Nome: {nome}\nEmail: {email}\nIdade: {idade}");
    }

}