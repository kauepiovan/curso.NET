int a , b , c ;

Console.Write("Digite o valor de a = ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o valor de b = ");
b = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o valor de c = ");
c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Equação quadratica: {a}X² + {b}X + {c} = 0");

var delta = Math.Pow(b, 2) - 4 * a * c;
var x1 = ((-b) + Math.Sqrt(delta)) / 2 * a;
var x2 = ((-b) - Math.Sqrt(delta)) / 2 * a;

if (((a * Math.Pow(x1, 2) + b * x1 + c) == 0) && ((a * Math.Pow(x1, 2) + b * x1 + c) == 0))
{
    Console.WriteLine("Ambas as raizes são reais e diferentes");
    Console.WriteLine($"x¹ = {x1}");
    Console.WriteLine($"x² = {x2}");
}
else
{
    Console.WriteLine("As raizes são imaginarias\nSem solução para esses numeros");
}