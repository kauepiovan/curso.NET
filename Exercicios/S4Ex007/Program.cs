using System.Net.Http.Headers;

var car = new Carro();
car.Modelo = "Sedan"; // SEDAN
car.Montadora = "vOlKs"; // volks
car.Marca = "jetta"; // jetta
car.Ano = 2002; // 2022
car.Potencia = 160; // 160

car.Exibir();
Console.WriteLine("\n");
car.Acelerar(car.Marca);
Console.WriteLine("\n");
car.MostrarPotencia();

public class Carro
{
    private string? modelo;
    public string? Modelo
    {
        get { return modelo; }
        set { modelo = value.ToUpper(); }
    }

    private string? montadora;
    public string? Montadora
    {
        get { return montadora; }
        set { montadora = value.ToLower(); }
    }

    private string? marca;
    public string? Marca { get {return marca;} set {marca = value;} }

    private int ano;
    public int Ano
    {
        get { return ano; }
        set
        {
            if (value < 2000)
            {
                ano = 2000;
            }
            else if (value > 2000)
            {
                ano = 2022;
            }
            else
            {
                ano = 0;
            }
        }
    }

    private int potencia;
    public int Potencia { set { potencia = value;} }

    public Carro() { }
    public Carro(string modelo, string montadora, string marca, int ano, int potencia)
    {
        this.Modelo = modelo;
        this.Montadora = montadora;
        this.Marca = marca;
        this.Ano = ano;
        this.Potencia = potencia;
    }

    public void Exibir()
    {
        Console.WriteLine
        (
            $"\nModelo: {modelo}\n"+
            $"Modelo: {montadora}\n"+
            $"Modelo: {marca}\n"+
            $"Modelo: {ano}\n"+
            $"Modelo: {potencia}\n"
        );
    }

    public void MostrarPotencia()
    {
        Console.WriteLine($"A potencia do {marca}: {potencia}");
    }

    public void Acelerar(string? marca)
    {
        Console.WriteLine($"Acelerando o meu {marca}");
    }
}