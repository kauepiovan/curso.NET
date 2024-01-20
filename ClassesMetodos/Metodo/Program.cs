// metodos

MinhaClasse minhaClasse = new MinhaClasse();
minhaClasse.Saudacao();

class MinhaClasse
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