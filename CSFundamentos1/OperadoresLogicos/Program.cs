using System.Security.Cryptography;

bool c1 = 5 >= 7; // false
bool c2 = 9 != 8; // true
bool resultado;

Console.WriteLine($"c1 = {c1}");
Console.WriteLine($"c2 = {c2}");

// operador AND -> && 
resultado = c1 && c2;
Console.WriteLine("operador AND(&&) :" + resultado);

// operador OR -> || 
resultado = c1 || c2;
Console.WriteLine("operador OR(||) :" + resultado);

// operador NOT -> !
resultado = !c1;
Console.WriteLine("operador NOT(!) :" + resultado);
