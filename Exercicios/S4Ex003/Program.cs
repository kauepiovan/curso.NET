Calcular calc = new();

var x = 10;
Console.WriteLine($"Valor de x = {x}");

Console.WriteLine($"\n chamando a funcao...\n");
calc.AumentarPotencia(x);
Console.WriteLine($"Valor de x = {x}");

Console.WriteLine($"\n chamando a funcao...\n");
calc.AumentarPotencia(ref x);
Console.WriteLine($"Valor de x = {x}");

public class Calcular
{
    public int AumentarPotencia(int numero)
    {
        numero += 3;
        Console.WriteLine($"valor da variavel dentro da funcao {numero}");
        return numero;
    }
    public int AumentarPotencia(ref int numero)
    {
        numero += 5;
        Console.WriteLine($"valor da variavel dentro da funcao {numero}");
        return numero;
    }
}