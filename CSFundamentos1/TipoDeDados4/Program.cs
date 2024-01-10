Console.WriteLine("Definindo variaveis do tipo string e object e dynamic");
Console.WriteLine();

string nome = "curso c#";
String titulo = "curso c# essencial";

// string não é deletada da memoria a não ser pelo garbage colector
// para aplicações com muitas alterações do tipo string é recomendado utilizar o StringBuilder]

Console.WriteLine(nome);
Console.WriteLine(titulo);

object nota = 10;
object valor = 8.55m;
object nome1 = "joao";
object ativa = true;
object letra = 'a';

Console.WriteLine(nota);
Console.WriteLine(valor);
Console.WriteLine(nome1);
Console.WriteLine(ativa);
Console.WriteLine(letra);

dynamic nota1 = 10;
dynamic valor1 = 8.55m;
dynamic nome2 = "joao";
dynamic ativa1 = true;
dynamic letra1 = 'a';

Console.WriteLine(nota1);
Console.WriteLine(valor1);
Console.WriteLine(nome2);
Console.WriteLine(ativa1);
Console.WriteLine(letra1);