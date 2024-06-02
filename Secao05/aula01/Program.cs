// Arrays

// declaracao do array
int[] numeros;

// alocar memoria
numeros = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

string[] nomes = new string[5] {"joao", "maria", "paulo", "jose", "carlos"};

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}

foreach (string nome in nomes)
{
    Console.WriteLine($"{nome}");
}

Exibir(nomes);
Array.Reverse(nomes);
Exibir(nomes);
Array.Sort(nomes);
Exibir(nomes);

var indice = Array.BinarySearch(nomes, "joao");

static void Exibir(string[] nomes)
{
    foreach (string nome in nomes)
    {
        Console.WriteLine($"{nome}  ");
    }
}

static int soma(params int[] numero)
{
    var total = 0;
    foreach (int num in numero)
    {
        total += num;
    }
    return total;
}

int[,] a = new int[2,2] {{1,2}, {1,2}};
int[,] b;