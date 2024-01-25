var calc = new Calcular();

int x = 20;

// metodo passando argumento por VALOR
Console.WriteLine($"(antes do metodo) Valor de x = {x}");
calc.Dobrar(x);
Console.WriteLine($"(depois do metodo) Valor de x = {x}");

// metodo passando argumento por REFERENCIA
Console.WriteLine($"(antes do metodo) Valor de x = {x}");
calc.Dobrar2(ref x);
Console.WriteLine($"(depois do metodo) Valor de x = {x}");

public class Calcular
{
    public void Dobrar(int y)  // metodo passando argumento por VALOR
    {
        y *= 2;
        Console.WriteLine($"Valor do parametro y = {y}");
    }
    public void Dobrar2(ref int y) // metodo passando argumento por REFERENCIA
    {
        y *= 2;
        Console.WriteLine($"Valor do parametro y = {y}");
    }
}