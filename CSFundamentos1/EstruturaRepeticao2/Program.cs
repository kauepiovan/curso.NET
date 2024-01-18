// estrutura de repeticao 2
// estrutura de repeticao for

int resultado, numero;

Console.WriteLine("Informe o numero desejado");
numero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"tabuada do numero {numero}");

for (int i = 0; i <= 10; i++)
{
    resultado = i * numero;
    Console.WriteLine($"{i} x {numero} = {resultado}");
}

Console.WriteLine("fim do programa");

for (int i = 0, j = 1, k = 2; k <= 10; i++, j++, k++)
{
    Console.WriteLine($"i = {i}, j = {j}, k = {k}");
}

for (int i = 0; i <= 10; i++)
{
    if (i == 5)
    {
        break;
    }
    if (i == 3)
    {
        continue;
    }

    Console.WriteLine(i);
}