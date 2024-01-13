// Operadores Uniarios e Ternarios


// operadores uniarios

Console.WriteLine(5/10);
Console.WriteLine("Student\t\tGrade");
int positivo = 1;
int resultado;

resultado = +positivo;
Console.WriteLine(resultado);

int negativo = -positivo;
resultado = negativo;
Console.WriteLine(resultado);
Console.WriteLine(-resultado);

// operadores ternarios
int temperatura1 = 28;
int temperatura2 = 25;

string resultado1 = temperatura1 > 27 ? "quente" : "normal";
string resultado2 = temperatura2 > 27 ? "quente" : "normal";

Console.WriteLine(resultado1);
Console.WriteLine(resultado2);

Console.WriteLine("Informe o valor de x");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe o valor de y");
int y = Convert.ToInt32(Console.ReadLine());

string resultado4 = x > y ? "x é maior que y" :
                    x < y ? "x é menor que y" :
                    x == y ? "x é igual a y" : "sem resultado";

Console.WriteLine(resultado4);