namespace Metodo;

public class Aluno
{
    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;

    public void Consultar()
    {
        var aluno = new Aluno();

        Console.Write("Nome: ");
        aluno.Nome = Console.ReadLine();
        Console.Write("Idade: ");
        aluno.Idade = Convert.ToInt32(Console.ReadLine());
        Console.Write("Sexo: ");
        aluno.Sexo = Console.ReadLine();
        Console.Write("Aprovado (S)im (N)ão: ");
        aluno.Aprovado = Console.ReadLine();

        Curso curso = new();
        curso.Resultado(aluno);
    }
}


public class Curso
{
    public void Resultado(Aluno aluno)
    {
        Console.WriteLine($"\nO aluno {aluno.Nome}, sexo {aluno.Sexo}, com {aluno.Idade} anos");
        if (aluno.Aprovado == "S" || aluno.Aprovado == "s")
        {
            Console.WriteLine("foi aprovado");
        }
        else
        {
            Console.WriteLine("foi reprovado");
        }
    }
}
