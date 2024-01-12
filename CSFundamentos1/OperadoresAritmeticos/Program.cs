// Operadores aritmeticos

Console.WriteLine("Informe o valor de X");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe o valor de Y");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Soma de X + Y = {x+y}");
Console.WriteLine($"Subtração de X - Y = {x-y}");
Console.WriteLine($"Multiplicação de X * Y = {x*y}");
Console.WriteLine($"Divisão de X / Y = {(double)x / y}");
Console.WriteLine($"Modulo de X * Y = {x % y}");

Console.WriteLine($"Raiz quadrada de X = {Math.Sqrt(x)}");
Console.WriteLine($"Potencia de X elevado a Y = {Math.Pow(x, y)}");
Console.WriteLine($"Valor Minimo entre X e Y = {Math.Min(x, y)}");
Console.WriteLine($"Valor Maximo entre X e Y = {Math.Max(x,y)}");
Console.WriteLine($"Cosseno de X = {Math.Cos(x)}");
Console.WriteLine($"Seno de X = {Math.Sin(x)}");
Console.WriteLine($"Exponencial de X = {Math.Exp(x)}");
