// construtores I

Aluno aluno = new Aluno();

Console.WriteLine(aluno.Nome == null ? "null" : aluno.Nome);
Console.WriteLine(aluno.Idade);
Console.WriteLine(aluno.Sexo == null ? "null" : aluno.Sexo);
Console.WriteLine(aluno.Aprovado == null ? "null" : aluno.Aprovado);



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