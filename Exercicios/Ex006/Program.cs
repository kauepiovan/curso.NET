Console.WriteLine("metodo 1");
for (int i1 = 10; i1 <= 20; i1++)
{
    if (i1 == 16)
        continue;
    if (i1 % 2 == 0)
        Console.WriteLine(i1);



}

Console.WriteLine("metodo 2");
for (int i2 = 10; i2 <= 20; i2 += 2)
{
    if (i2 == 16)
    {
        continue;
    }

    Console.WriteLine(i2);

}

Console.WriteLine("metodo 3");
int i3 = 10;
while (true)
{
    if (i3 == 16)
    {
        i3 += 2;
        continue;
    }

    Console.WriteLine(i3);

    if (i3 == 20)
    {
        break;
    }

    i3 += 2;
}