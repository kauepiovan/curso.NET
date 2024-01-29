// construtores I

Aluno aluno = new Aluno();

Console.WriteLine(aluno.Nome == null ? "null" : aluno.Nome);
Console.WriteLine(aluno.Idade);
Console.WriteLine(aluno.Sexo == null ? "null" : aluno.Sexo);
Console.WriteLine(aluno.Aprovado == null ? "null" : aluno.Aprovado);

var cliente = new Cliente(null, 24);

Console.WriteLine(cliente.Nome);
Console.WriteLine(cliente.Idade);

var teste = new Teste();
// teste.Num1 = 10;
// teste.Num2 = 5;
// teste.Exibir();


var teste1 = new Teste1(50, 20);

Console.ReadLine();

public class Aluno
{
    public Aluno()
    {
    }
    public Aluno(string nome)
    {
        Nome = nome;
    }
    public Aluno(int idade, string sexo, string aprovado)
    {
        Idade = idade;
        Sexo = sexo;
        Aprovado = aprovado;
    }
    public Aluno(string nome, int idade, string sexo, string aprovado):this(nome)
    {
        Idade = idade;
        Sexo = sexo;
        Aprovado = aprovado;
    }

    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;
}

public class Cliente
{
    public string? Nome;
    public int Idade;

    public Cliente(string? Nome, int Idade)
    {
        // usando a propriedade this no construtor para
        // atribuir valor com variavel e parametros com o mesmo nome
        this.Nome = Nome;
        this.Idade = Idade;
    }
}

public class Teste
{
    public int Num1;
    public int Num2;

    private void PassarParametro(Teste t)
    {
        Console.WriteLine($"this = {this}");
        Console.WriteLine($"num1 = {t.Num1}");
        Console.WriteLine($"num1 = {t.Num2}");
    }

    public void Exibir()
    {
        PassarParametro(this);
    }
}

public class Teste1
{
    public Teste1(int num1, int num2)
    {
        Console.WriteLine($"construtor com 2 parametros num1={num1}, num2={num2}");
    }
    public Teste1(int num3) : this(100, 200)
    {
        Console.WriteLine($"construtor com 1 parametro num3={num3}");
    }
}