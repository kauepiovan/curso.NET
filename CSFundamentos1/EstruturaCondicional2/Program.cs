﻿// Estrutura condicionais
Console.WriteLine("Iforme a nota do aluno");
var nota = Convert.ToDouble(Console.ReadLine());

if (nota < 5)
{
    Console.WriteLine("Aluno reprovado");
}
else if (nota >= 5 && nota < 6)
{
    Console.WriteLine("Aluno em recuperação");
}
else if (nota >= 6 && nota <= 9)
{
    Console.WriteLine("Aluno Aprovado");
}
else if (nota > 9) 
{
    Console.WriteLine("Aluno aprovado com distinção");
}