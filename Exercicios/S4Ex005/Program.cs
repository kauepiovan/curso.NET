ExibirInfo(modelo: "fusca", montadora: "volkswagen", marca: "volkswagen", potencia: 90);
ExibirInfo(modelo: "fusca", montadora: "volkswagen", marca: "volkswagen", potencia: 90, ano: 1940);

static void ExibirInfo(string modelo, string montadora, string marca, int potencia, int ano = 0)
{
    Console.WriteLine(
        $"\nModelo: {modelo}\n"+
        $"Montadora: {montadora}\n"+
        $"Marca: {marca}\n"+
        $"Potencia: {potencia}\n"+
        $"Ano: {ano}\n"
        );
}