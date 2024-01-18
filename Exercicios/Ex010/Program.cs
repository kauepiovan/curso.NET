Console.WriteLine("Digite sua nota:");
int notaUsuario = Convert.ToInt32(Console.ReadLine());

switch(notaUsuario)
{
    case 10:
        Console.WriteLine("Sua nota foi A+");
        break;
    case 9:
        Console.WriteLine("Sua nota foi A");
        break;
    case 8:
    case 7:
        Console.WriteLine("Sua nota foi B");
        break;
    case 6:
        Console.WriteLine("Sua nota foi C");
        break;
    case 5:
        Console.WriteLine("Sua nota foi E");
        break;
    default:
        Console.WriteLine("Sua nota foi F");
        break;

}