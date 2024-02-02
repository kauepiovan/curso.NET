using Enum;
using Models;

Console.WriteLine($"Cores disponiveis");
Console.WriteLine($"{(int)Cores.Branco} - {Cores.Branco}");
Console.WriteLine($"{(int)Cores.Vermelho} - {Cores.Vermelho}");
Console.WriteLine($"{(int)Cores.Preto} - {Cores.Preto}");
Console.WriteLine($"{(int)Cores.Cinza} - {Cores.Cinza}");
Console.WriteLine($"{(int)Cores.Prata} - {Cores.Prata}");

Console.Write("Digite o numero da cor desejada: ");
int entradaUsuario = Convert.ToInt32(Console.ReadLine());

var carro = new Carros.Carro(entradaUsuario);

Console.WriteLine($"A cor escolhida para seu carro foi: {(Cores)carro.Cor}");
carro.ExibirInfo();