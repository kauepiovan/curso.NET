// Propriedades

Produto p1 = new Produto();

p1.Nome = "Caderno";
p1.Preco = 3.00;
p1.EstoqueMinimo = 10;
p1.Exibir();

public class Produto
{
    private string? nome; // campo de apoio (private)
    public string? Nome
    {   // fazendo modficacoes para retornar o nome em maiusculas
        get { return nome?.ToUpper(); } // leitura
        set { nome = value; } // gravacao
    }

    private double preco;
    public double Preco
    {
        get { return preco; }
        set
        {   // fazendo modificacao para retornar 5 caso valor seja < que 5
            if (value < 5.00)
                preco = 5.00;
            else
                preco = value;
        }
    }

    private double desconto = 0.05; // campo de apoio (private)
    public double Desconto // Propriedade somente de leitura/acesso (get)
    {
        get { return desconto; }
    }

    public double PrecoFinal
    {   // fazendo retornar apenas o preco final
        get { return Preco - (Preco * Desconto); }
    }

    private int minimo;
    public int EstoqueMinimo
    {
        set{ minimo = value; }
    }

    public void Exibir()
    {
        Console.WriteLine($"{Nome}\n{Preco.ToString("c")}\n{Desconto}\n{PrecoFinal.ToString("c")}\n{minimo}");
    }
}