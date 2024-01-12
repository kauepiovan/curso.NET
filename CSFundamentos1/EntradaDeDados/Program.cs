//entrada de dados

Console.WriteLine("Digite seu nome\n");
string nome = Console.ReadLine();

Console.WriteLine("Digite sua idade\n");
int idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Seu nome é {nome}");
Console.WriteLine($"Sua idade é {idade} anos");


Console.Read(); // le apenas o primeiro caractere e retorna o ASCII dele
Console.ReadKey(); // le a tecla pressionada