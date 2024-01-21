using Metodo;

var aluno = new Aluno();

Console.Write("Nome: ");
aluno.Nome = Console.ReadLine();

Console.Write("Idade: ");
aluno.Idade = Convert.ToInt32(Console.ReadLine());

Console.Write("Sexo: ");
aluno.Sexo = Console.ReadLine();

Console.Write("Aprovado (S)im (N)ão: ");
aluno.Aprovado = Console.ReadLine();

Curso curso = new();
curso.Resultado(aluno.Nome, aluno.Idade, aluno.Sexo, aluno.Aprovado);
