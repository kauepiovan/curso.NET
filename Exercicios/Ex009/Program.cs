int i = 2;
while (i <= 6)
{
    int j = 0;
    while (j <= 10)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
        j++;
    }
    Console.WriteLine();
    i++;
}