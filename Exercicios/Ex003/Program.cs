Console.WriteLine("while");
int soma1 = 0, i1 = 0;
while (i1 <= 9)
{
    i1++;
    Console.WriteLine(i1);
    soma1 += i1;
}
Console.WriteLine($"Soma: {soma1}");

Console.WriteLine("do while");
int soma2 = 0, i2 = 0;
do
{
    i2++;
    Console.WriteLine(i2);
    soma2 += i2;

} while (i1 <= 9);
Console.WriteLine($"Soma: {soma2}");

Console.WriteLine("for");
int soma = 0;
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
    soma += i;
}
Console.WriteLine($"Soma: {soma}");