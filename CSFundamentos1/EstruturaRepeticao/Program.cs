// Estruturas de Repetição

// laço de repetição usando GOTO
Console.WriteLine("Estrutura de repetição GOTO");

int i = 0;

repetir: // label
Console.WriteLine($"i = {i}");
i++; // incremento
if (i <= 10)
{
    goto repetir; // estrução GOTO
}

Console.WriteLine("Fim da repetição goto.");


// laço de repetição usando WHILE

Console.WriteLine("Estrutura de repetição While");
i = 0;
while (i <= 10) // condicão que ira checar
{
    Console.WriteLine($"i = {i}");
    i++; // incremento
}

Console.WriteLine("Estrutura while com ordem reversa");
i = 10;
while (i >= 10) // condição que ira checar
{
    Console.WriteLine($"i = {i}");
    i--; // decremento
}
Console.WriteLine("Fim do laço de repetição while.");

while (true)
{
    Console.WriteLine("Informe um numero inteiro (digite 999 para sair): ");
    int entradaUsuario = Convert.ToInt32(Console.ReadLine());

    if (entradaUsuario == 999) // condição de parada
    {
        break; // instrução de parada
    }
    else
    {
        if (entradaUsuario % 2 == 0)
        {
            Console.WriteLine($"{entradaUsuario} é par.");
        }
        else
        {
            Console.WriteLine($"{entradaUsuario} é impar.");
        }
    }
}
Console.WriteLine("programa finalizado");

// while aninhado
int x = 0, y = 0;
while (x <= 5)
{
    while (y <= 5)
    {
        Console.Write($"({x}|{y}) ");
        y++;
    }
    Console.WriteLine();
    y = 0;
    x++;
}


// tabuada de um numero usando while
Console.WriteLine("## Tabuada ##");

int contador, numero;

Console.WriteLine("Digite o numero da tabuada: ");
numero = Convert.ToInt32(Console.ReadLine());

if (numero >= 0)
{
    Console.WriteLine($"--\t\t tabuada do {numero}\t\t --");

    contador = 0;
    while (contador <= 10)
    {
        Console.WriteLine($"{contador} x {numero} = {contador * numero}");
        contador++;
    }
}
else
{
    Console.WriteLine("Digite um numero maior ou igual a 0");
}
Console.WriteLine("Fim do programa tabuada");

// estrutura de repetição do while
i = 0;
do // executa pelo menos 1 vez o laco de repeticao
{
    Console.WriteLine($"i = {i}");
    i++;
    if (i > 7) // condicao de parada
    {
        break;
    }
}
while (i <= 10); // verifica a condicao de repeticao (somente no final da execucao do bloco de codigo)
// do while aninhado

x = 0;
do
{
    y = 0;
    do
    {
        Console.WriteLine($"({x}, {y})");
        y++;
    }
    while (y <= 5);
    Console.WriteLine();
    x++;
}
while (x <= 5);