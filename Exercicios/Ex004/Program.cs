while (true)
{
    Console.WriteLine("Informe o numero desejado (para sair pressione S)");
    var entradaUsuario = Console.ReadLine();

    if (entradaUsuario == "s" || entradaUsuario == "S")
    {
        break;
    }
    else
    {
        int numeroUsuario = Convert.ToInt32(entradaUsuario);

        if (numeroUsuario > 0)
        {
            Console.WriteLine($"Tabuada do numero {numeroUsuario}");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{i} x {numeroUsuario} = {i * numeroUsuario}");
            }
        }
        else if (numeroUsuario <= 0)
        {
            Console.WriteLine("Por favor informe um numero maior que 0");
        }

    }

}
Console.WriteLine("Programa finalizado");