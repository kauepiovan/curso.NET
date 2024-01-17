// Estrutura condicional

int compra = 600;
Console.WriteLine($"valor da compra ${compra}\n");
Console.WriteLine("Digite o numero de parcelas de 1 a 3 \n");
var parcelas = Convert.ToInt32(Console.ReadLine());

switch (parcelas)
{
    case 1 :
        Console.WriteLine($"\n Prestação R${compra / parcelas}");
        break;
    case 2 :
        Console.WriteLine($"\n Prestação R${compra / parcelas}");
        break;
    case 3 :
        Console.WriteLine($"\n Prestação R${compra / parcelas}");
        break;
    default:
        Console.WriteLine("Insira um valor valido de 1 a 3");
        break;
}
Console.WriteLine("fim do programa");


// par ou impar com switch
Console.WriteLine("Digite um numero e descubra se ele é par ou impar\n");
int numero = Convert.ToInt32(Console.ReadLine());

switch (numero % 2)
{
    case 0:
        Console.WriteLine($"O numero {numero} é par");
        break;
    case 1:
        Console.WriteLine($"O numero {numero} é impar");
        break;
    default:
        Console.WriteLine("Insira um tipo de dado valido");
        break;
}
Console.WriteLine("Fim do programa");