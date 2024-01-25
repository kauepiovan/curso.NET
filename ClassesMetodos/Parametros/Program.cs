var calc = new Calcular();

int x = 20;
Console.WriteLine($"(antes do metodo) Valor de x = {x}");
calc.Dobrar(x);
Console.WriteLine($"(depois do metodo) Valor de x = {x}");

public class Calcular
{
    public void Dobrar(int y)
    {
        y *= 2;
        Console.WriteLine($"Valor do parametro y = {y}");
    }
}