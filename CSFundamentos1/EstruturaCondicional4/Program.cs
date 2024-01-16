// Estruturas Condicionais

Console.WriteLine("Informe o nome do mês: ");
string nomeMes = Console.ReadLine().ToLower();

switch (nomeMes)
{
    case "janeiro":
    case "março":
    case "maio":
    case "julho":
    case "agosto":
    case "outubro":
    case "dezembro":
        Console.WriteLine("Este mês tem 31 dias");
        break;
    case "fevereiro":
    {
        Console.WriteLine("Este mês tem 28 ou 29 dias");
        break;
    }
    default:
        Console.WriteLine("Este mês tem 30 dias");
        break;
}
Console.WriteLine("fim do programa");


Console.WriteLine("Digite sua função gerente(1) programdor(2)");
var funcao = Convert.ToInt32(Console.ReadLine());
switch(funcao)
{
    case 1 :
        Console.WriteLine("Bem vindo gerente");
        break;
    case 2 :
        Console.WriteLine("Digite o seu nivel junior(1) pleno(2) senior(3) ");
        var nivelProgramador = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Bem vindo programador");
        
        switch(nivelProgramador)
        {
            case 1:
                Console.WriteLine("Você é junior");
                break;
            case 2:
                Console.WriteLine("Você é pleno");
                break;
            case 3:
                Console.WriteLine("Você é Senior");
                break;
            default:
                Console.WriteLine("Opção invalida");
                break;
        }
        break;
    default:
        Console.WriteLine("Opção Invalida");
        break;
}
Console.WriteLine("fim do programa");
