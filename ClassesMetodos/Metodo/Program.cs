// metodos
MinhaClasse minhaClasse = new();

minhaClasse.Saudacao("joão", DateTime.Now.ToShortDateString());

// Classes e metodos

class MinhaClasse
{
    public void Saudacao(string nome, string data)
    {
        Console.WriteLine(nome);
        Console.WriteLine(data);
    }
}


// class MinhaClasse
// {
//     public void Saudacao()
//     {
//         Console.WriteLine("Seja bem vindo");
//         ExibirDataAtual();
//     }

//     public void ExibirDataAtual()
//     {
//         Console.WriteLine(DateTime.Now.ToShortDateString());
//     }
// }