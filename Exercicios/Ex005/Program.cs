Console.WriteLine("Qual a instrução para sair de um loop?\na)quit\nb)continue\nc)break\nd)exit");
var respostaCorreta = 'c';

while (true)
{
    Console.WriteLine("Qual a resposta correta? (tecle X para sair) ");
    char respostaUsuario = Convert.ToChar(Console.ReadLine());

    if (respostaUsuario == 'x' || respostaUsuario == 'X')
    {
        break;
    }

    if (respostaUsuario == respostaCorreta)
    {
        Console.WriteLine("Resposta Correta");
        break;
    }
    
    Console.WriteLine("Resposta Incorreta.");
}
Console.WriteLine("programa finalizado");