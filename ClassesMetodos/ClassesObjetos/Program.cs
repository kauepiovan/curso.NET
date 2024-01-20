// classes e Objetos

Pessoa p1 = new Pessoa();
p1.Nome = "joao";
p1.Idade = 20;
p1.Sexo = "Masculino";

Console.WriteLine($"{p1.Nome}, {p1.Idade}, {p1.Sexo}");

Pessoa p2 = new Pessoa();
p2.Nome = "maria";
p2.Idade = 22;
p2.Sexo = "Feminino";
System.Console.WriteLine("");
Console.WriteLine($"{p2.Nome}, ${p2.Idade}, {p2.Sexo}");

class Pessoa
{
    public string? Nome;
    public int Idade;
    public string? Sexo;
}