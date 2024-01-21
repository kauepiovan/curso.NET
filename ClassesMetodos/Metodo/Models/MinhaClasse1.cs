namespace Metodo;

class MinhaClasse1
{
    public void Saudacao()
    {
        Console.WriteLine("Seja bem vindo");
        ExibirDataAtual();
    }

    public void ExibirDataAtual()
    {
        Console.WriteLine(DateTime.Now.ToShortDateString());
    }
}