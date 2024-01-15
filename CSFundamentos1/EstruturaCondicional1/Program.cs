// estruturas condicionais

Console.WriteLine("informe a nota do aluno");
var notaAluno = Convert.ToInt32(Console.ReadLine());

if (notaAluno > 5)
{
    Console.WriteLine("Aluno Aprovado");
}
else
{
    Console.WriteLine("Aluno Reprovado");
}

Console.WriteLine("Informe o valor de x");
var x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("informe o valor de y");
var y = Convert.ToInt32(Console.ReadLine());

if (x > y)
{
    Console.WriteLine("X é maior que Y");
}
else
{
    if (x < y)
    {
        Console.WriteLine("X é menor que Y");
    }
    else 
    {
        Console.WriteLine("X é igual a Y");
    }
}
