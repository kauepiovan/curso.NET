// byte    =  1 byte
// short   =  2 bytes
// int     =  4 bytes
// long    =  8 bytes
// float   =  4 bytes
// double  =  8 bytes
// decimal =  16 bytes

// conversao implicita
int numeroInt = 2145678;
long numeroLong = numeroInt;
float numeroFloat = numeroInt;
double numeroDouble = numeroInt;
decimal numeroDecimal = numeroInt;

Console.WriteLine(numeroInt);
Console.WriteLine(numeroLong);
Console.WriteLine(numeroFloat);
Console.WriteLine(numeroDouble);
Console.WriteLine(numeroDecimal);

// conversao explicita
double varDouble = 12.456;
int varInt = (int)varDouble;
Console.WriteLine(varInt);

int num1 = 10;
int num2 = 4;

float resultado = (float)num1 / num2;
Console.WriteLine(resultado);

// convertendo para string com Objetct.ToString();

int valor1 = 1234;
decimal valor2 = 0.1245m;
string s1 = valor1.ToString();
string s2 = valor2.ToString();
Console.WriteLine(s1);
Console.WriteLine(s2);

// convertendo usando a classe convert

int valorInt = 10;
double valorDouble = 5.35;
bool valorBool = true;

Console.WriteLine(Convert.ToString(valorInt));
Console.WriteLine(Convert.ToDouble(valorInt));
Console.WriteLine(Convert.ToString(valorBool));
Console.WriteLine(Convert.ToInt32(valorDouble));

