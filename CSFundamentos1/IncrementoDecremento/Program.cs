// Incremento e Decremento 

int x = 0;
Console.WriteLine(x);
x++;
Console.WriteLine(x);
x++;
Console.WriteLine(x);
x--;
Console.WriteLine(x);
x--;
Console.WriteLine(x);

// pré e pos Incremento e Decremento

int y = 0;

//pós incremento e decremento => primeiro resolve depois incrementa ou decrementa
int resultado1 = y++ + 10;
Console.WriteLine(resultado1);
Console.WriteLine(x);

int resultado3 = y-- + 10;
Console.WriteLine(resultado3);
Console.WriteLine(y);

//pré incremento e decremento => primeiro incrementa ou decrementa e depois resolve
int resultado2 = ++y + 10;
Console.WriteLine(resultado2);
Console.WriteLine(x);


int resultado4 = --y + 10;
Console.WriteLine(resultado4);
Console.WriteLine(y);