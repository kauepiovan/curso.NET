var calc = new Calcular();

int potencia = 10;
potencia = calc.AumentarPotenciaVelocidade(potencia, out double velocidade);
Console.WriteLine($"Potencia = {potencia}\nVelocidade = {velocidade}");

public class Calcular 
{
    public int AumentarPotenciaVelocidade(int potencia, out double velocidade)
    {
        int novaPotencia = potencia + 7;
        velocidade = potencia * 1.75;
        return novaPotencia;
    }
}