Console.WriteLine("digite um numero");
int numero1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a operação (+ - / *)");
char operacao = Convert.ToChar(Console.ReadLine());

Console.WriteLine("digite outro numero");
int numero2 = Convert.ToInt32(Console.ReadLine());

switch (operacao)
{
    case '+':
        Console.WriteLine($"{numero1} + {numero2} = {numero1 + numero2}");
        break;
    case '-':
        Console.WriteLine($"{numero1} - {numero2} = {numero1 - numero2}");
        break;
    case '*':
        Console.WriteLine($"{numero1} * {numero2} = {numero1 * numero2}");

        break;
    case '/':
        if (numero2 == 0)
        {
            Console.WriteLine("Divisão por 0 impossivel");
            break;
        }
        else
        {
        Console.WriteLine($"{numero1} / {numero2} = {numero1 / (float)numero2}");
        break;
        }
        
}
