namespace Metodo;

public class Aluno
{
    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;
}
public class Curso
{
    public void Resultado(string? nome, int idade, string? sexo, string? aprovado)
    {
        Console.WriteLine($"\nO aluno {nome}, sexo {sexo}, com {idade} anos");
        if (aprovado == "S" || aprovado == "s")
        {
            Console.WriteLine("foi aprovado");
        }
        else
        {
            Console.WriteLine("foi reprovado");
        }
    }
}
