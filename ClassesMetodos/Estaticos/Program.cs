// metodos estaticos

var soma = Calculadora.Soma;
var subtrair = Calculadora.Sub;
var multiplicar = Calculadora.Mult;
var dividir = Calculadora.Div;

Console.WriteLine(Calculadora.Soma(5, 5));
Console.WriteLine(Calculadora.Sub(5, 5));
Console.WriteLine(Calculadora.Mult(5, 5));
Console.WriteLine(Calculadora.Div(5, 5));

// metodos com a modificador static nao precisam ser inicializados
// para serem chamados.

Console.WriteLine(soma(2, 2));
Console.WriteLine(subtrair(5, 10));
Console.WriteLine(multiplicar(2, 8));
Console.WriteLine(dividir(30, 15));

Console.WriteLine("=================== campos estaticos ==================================");
// campos estaticos
var a1 = new A();
a1.x = 10;
var a2 = new A();
a2.x = 20;
A.y = 30; // campo estatico

Console.WriteLine($"\na1.x = {a1.x} a2.x = {a2.x} A.y = {A.y}");

Console.WriteLine("\n============ exemplo de utilizacao de campos estaticos =============");

ContaCorrente c1 = new();
c1.Conta = 101;
c1.Nome = "joao";
// c1.Juros = 3.99f;
ContaCorrente c2 = new();
c2.Conta = 102;
c2.Nome = "maria";
// c2.Juros = 4.99f;

ContaCorrente.Juros = 4.25f;

Console.WriteLine($"\nCliente: {c1.Nome} - Juros Anula: {c1.JurosAnual()}");
Console.WriteLine($"\nCliente: {c2.Nome} - Juros Anula: {c2.JurosAnual()}");

// Construtor estatico
Console.WriteLine("\n================= Construtores Estaticos ======================");
// O construtor estatico somente eh inicializado na primeira vez que a Classe pessoa
// eh inicializada como objeto. Depois ele nao eh mais chamado.

// Invoca o construtor parametrizado e o estatico
Pessoa p1 = new(19, "Maria");
Console.WriteLine(p1.Nome + " - " + p1.Idade);

// note que o construtor estatico nao sera chamado. Somente o parametrizado.
Pessoa p2 = new(20, "Manoel");
Console.WriteLine(p2.Nome + " - " + p2.Idade);


public class A // campos estaticos
{
    public int x;
    public static int y; // criacao do campo estatico
}

public class Calculadora
{
    public static int Soma(int num1, int num2)
    {
        return num1 + num2;
    }
    public static int Sub(int num1, int num2)
    {
        return num1 - num2;
    }
    public static int Mult(int num1, int num2)
    {
        return num1 * num2;
    }
    public static int Div(int num1, int num2)
    {
        return num1 / num2;
    }
}

public class ContaCorrente // exemplo de utilizacao do campo estatico

{
    public int Conta;
    public string? Nome;
    public static float Juros;

    public float JurosAnual()
    {
        return Juros * 12;
    }
}

public class Pessoa
{
    public static int IdadeMinima;
    public int Idade { get; set; }
    public string Nome { get; set; } = string.Empty;

    public Pessoa(int idade, string nome)
    {
        Console.WriteLine("\nExecutando construtor parametrizado");
        Idade = idade;
        Nome = nome;
    }
    public Pessoa()
    { }
    static Pessoa()
    {
        Console.WriteLine("\nExecutando Construtor Estatico...");
        Console.WriteLine("\nInicializando o campo IdadeMinima");
        IdadeMinima = 18;
    }

}