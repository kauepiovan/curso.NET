var chevrolet = new Carro();
chevrolet.Modelo = "Sedan";
chevrolet.Montadora = "Chevrolet";
chevrolet.Marca = "Onix";
chevrolet.Ano = 2016;
chevrolet.Potencia = 110;

var ford = new Carro();
ford.Modelo = "SUV";
ford.Montadora = "Ford";
ford.Marca = "EcoSport";
ford.Ano = 2018;
ford.Potencia = 120;

Console.WriteLine(
    $"carro 01\n" +
    $"modelo: {chevrolet.Modelo}\n" +
    $"montador: {chevrolet.Montadora}\n" +
    $"marca: {chevrolet.Marca}\n" +
    $"ano: {chevrolet.Ano}\n" +
    $"potencia: {chevrolet.Potencia}"
);
chevrolet.Acelerar(chevrolet.Marca);

Console.WriteLine("\n");

Console.WriteLine(
    $"carro 02\n" +
    $"modelo: {ford.Modelo}\n" +
    $"montador: {ford.Montadora}\n" +
    $"marca: {ford.Marca}\n" +
    $"ano: {ford.Ano}\n" +
    $"potencia: {ford.Potencia}"
);
ford.Acelerar(ford.Marca);

Console.WriteLine("\n");

var carro1 = new Carro("Sedan", "Chevrolet", "Onix", 2016, 110);
var carro2 = new Carro("SUV", "Ford", "EcoSport", 2018, 120);
carro1.Acelerar(carro1.Marca);
carro2.Acelerar(carro2.Marca);

public class Carro
{
    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    public int Ano;
    public int Potencia;

    public Carro() { }
    public Carro(string Modelo, string Montadora, string Marca, int Ano, int Potencia)
    {
        this.Modelo = Modelo;
        this.Montadora = Montadora;
        this.Marca = Marca;
        this.Ano = Ano;
        this.Potencia = Potencia;
    }

    public void Acelerar(string? marca)
    {
        Console.WriteLine($"Acelerando o meu {marca}");
    }
}