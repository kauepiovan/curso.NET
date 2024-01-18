Console.WriteLine("Digite o numero desejado");
var entradaUsuario = Console.ReadLine();
int numero = Convert.ToInt32(entradaUsuario);
int resultado = 1;
for (int i = numero; i >= 1; i--)
{
    resultado *= i;
}
Console.WriteLine("fatorial de " + numero + " é " + resultado);