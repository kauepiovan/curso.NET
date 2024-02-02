// Enum
using Enumerations;

Console.WriteLine(DiasDaSemana.Terca);
Console.WriteLine(DiasDaSemana.Quarta);

Console.WriteLine((int)DiasDaSemana.Segunda);
Console.WriteLine((int)DiasDaSemana.Terca);
Console.WriteLine((int)DiasDaSemana.Quarta);
Console.WriteLine((int)DiasDaSemana.Quinta);
Console.WriteLine((int)DiasDaSemana.Sexta);
Console.WriteLine((int)DiasDaSemana.Sabado);

var segunda = DiasDaSemana.Segunda;
var valorSegunda = (int)segunda;

Console.WriteLine($"O valor de {segunda} eh {valorSegunda}");
Console.WriteLine($"O valor de {DiasDaSemana.Terca} eh {(int)DiasDaSemana.Terca}");

Console.WriteLine("=========================================================================================");

Console.WriteLine($"{Categorias.Moda} - {(int)Categorias.Moda}:");
Console.WriteLine($"{Categorias.Automotivo} - {(int)Categorias.Automotivo}:");
Console.WriteLine($"{Categorias.Artes} - {(int)Categorias.Artes}:");
Console.WriteLine($"{Categorias.Bebidas} - {(int)Categorias.Bebidas}:");
Console.WriteLine($"{Categorias.Livros} - {(int)Categorias.Livros}:");
Console.WriteLine($"{Categorias.Brinquedos} - {(int)Categorias.Brinquedos}:");

// selecionando um enum pelo valor
Console.WriteLine("\nSelecione a Categoria teclando o seu valor");
int valor = Convert.ToInt32(Console.ReadLine());

var nomeMembroEnum = (Categorias)valor;
Console.WriteLine("\nVoce selecionou a categoria: " + nomeMembroEnum.ToString());
