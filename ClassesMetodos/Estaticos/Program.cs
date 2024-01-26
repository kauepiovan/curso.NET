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

Console.WriteLine(soma(2,2));
Console.WriteLine(subtrair(5,10));
Console.WriteLine(multiplicar(2,8));
Console.WriteLine(dividir(30,15));

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