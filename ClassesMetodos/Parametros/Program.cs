var calc = new Calcular(); 
int x = 20;
// metodo passando argumento por VALOR
Console.WriteLine($"(antes do metodo) Valor de x = {x}");
calc.Dobrar(x);
Console.WriteLine($"(depois do metodo) Valor de x = {x}");

// metodo passando argumento por REFERENCIA
Console.WriteLine($"(antes do metodo) Valor de x = {x}");
calc.Dobrar2(ref x); // usando o REF
Console.WriteLine($"(depois do metodo) Valor de x = {x}\n");

Console.WriteLine("=================================================\n");

var circ = new Circulo();

double raio = 10;
double perimetro = circ.CalcularPerimetroArea(raio, out double area); // usando o OUT

Console.WriteLine($"O valor calculado do perimetro eh: " + perimetro);
Console.WriteLine($"O valor calculado do area eh: " + area);


public class Circulo // usando o OUT
{
    public double CalcularPerimetroArea(double raio, out double area)
    {
        area = Math.PI * Math.Pow(raio, 2);
        double perimetro = 2 * Math.PI * raio;
        return perimetro;
    }
}
public class Calcular // usando o REF
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