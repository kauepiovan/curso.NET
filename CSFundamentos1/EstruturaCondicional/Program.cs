// estruturas condicionais 

Console.WriteLine("é um cliente especial? (s/n)");
var isEspecialClient = Console.ReadLine();

if (isEspecialClient == "s")
{
    Console.WriteLine("Desconto de 10% aplicado");
}

Console.WriteLine("fim do programa");

Console.WriteLine("digite o numero de x");
var x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("digite o numero de y");
var y = Convert.ToInt32(Console.ReadLine());

if (x > y) 
{
    Console.WriteLine("x é maior que y");
}
if (x < y) 
{
    Console.WriteLine("x é menor que y");
}
if (x == y)
{
    Console.WriteLine("x é igual a y");
}