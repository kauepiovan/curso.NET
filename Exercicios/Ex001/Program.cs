Console.WriteLine("exercicio - 01");

int maiorNumero = int.MinValue;
for (int i = 0; i <= 2; i++)
{
    Console.Write("Digite um numero: ");
    int numeroDigitado = Convert.ToInt32(Console.ReadLine());

    if (numeroDigitado > maiorNumero)
    {
        maiorNumero = numeroDigitado;
    }
}
Console.WriteLine($"O maior numero digitador foi {maiorNumero}");