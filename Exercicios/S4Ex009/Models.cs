namespace Carros;
using Enum;

public class Carro
{
    public Carro(int cor)
    {
        Cor = cor;
    }

    private int cor = 1;
    public int Cor { get { return cor; } set { cor = value; } }

    public void ExibirInfo()
    {
        Console.WriteLine($"Seu carro eh {(Cores)cor}");
    }
}
