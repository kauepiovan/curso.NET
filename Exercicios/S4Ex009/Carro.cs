namespace Models;
using Enum;

public class Carro
{
    public Carro(int cor)
    {
        Cor = cor;
    }

    private int cor = 1;
    public int Cor { get { return cor; } set { cor = value; } }

    void ExibirInfor()
    {
        Console.WriteLine($"Seu carro eh {(Cores)cor}");
    }
}
