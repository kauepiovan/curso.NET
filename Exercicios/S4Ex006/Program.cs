Ipva.ObterValorIpva();

Console.WriteLine(Ipva.ValorIpva);

public class Ipva
{
    public static double ValorIpva;

    public static void ObterValorIpva()
    {
        ValorIpva += 4;
    }
}
