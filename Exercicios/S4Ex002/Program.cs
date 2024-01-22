var carro01 = new Carro("Sedan", "Lancer");
double potencia = carro01.VelocidadeMaxima(150);

Console.WriteLine(potencia);

public class Carro
{
    public string? Modelo;
    public string? Marca;

    public Carro(string modelo, string marca)
    {
        Modelo = modelo;
        Marca = marca;
    }

    public double VelocidadeMaxima(int potencia)
    {
        return potencia * 1.75;
    }
}