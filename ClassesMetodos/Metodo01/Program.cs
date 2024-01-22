// metodos com retorno

var calc = new Calculadora();

Console.WriteLine(calc.Soma(10, 5));
Console.WriteLine(calc.Sub(10, 5));
Console.WriteLine(calc.Mult(10, 5));
Console.WriteLine(calc.Div(10, 5));


public class Calculadora
{
    public int Soma(int num1, int num2)
    {
        return num1 + num2;
    }
    public int Sub(int num1, int num2)
    {
        return num1 - num2;
    }
    public int Mult(int num1, int num2)
    {
        return num1 * num2;
    }
    public int Div(int num1, int num2)
    {
        return num1 / num2;
    }
}