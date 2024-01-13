// Precedencia de operadores

int x = (10 - 2) * 3;

Console.WriteLine(x);

bool a = !(9 != 8) && 5 >= 7 || 8 >= 6;
Console.WriteLine(a);
bool b = !(9 != 8) && (5 >= 7 || 8 >= 6);
Console.WriteLine(b);

int a1 = 5, b1 = 6, c1 = 4;

int r = --a1 * b1 - ++c1;

Console.WriteLine(r);