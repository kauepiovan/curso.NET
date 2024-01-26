Console.WriteLine("\n\n========== PASSANDO ARGUMENTOS POR VALOR======================");
var calc = new Calcular();
int x = 20;
// metodo passando argumento por VALOR
Console.WriteLine($"(antes do metodo) Valor de x = {x}");
calc.Dobrar(x);
Console.WriteLine($"(depois do metodo) Valor de x = {x}");

Console.WriteLine("\n\n========== PASSANDO ARGUMENTOS POR REFERENCIA (REF)==========");
// metodo passando argumento por REFERENCIA USANDO REF
Console.WriteLine($"(antes do metodo) Valor de x = {x}");
calc.Dobrar2(ref x); // usando o REF
Console.WriteLine($"(depois do metodo) Valor de x = {x}\n");

Console.WriteLine("\n\n========== PASSANDO ARGUMENTOS POR REFERENCIA (OUT)==========");
// metodo passando argumentos por REFERENCIA USANDO OUT
var circ = new Circulo();
double raio = 10;
double perimetro = circ.CalcularPerimetroArea(raio, out double area); // usando o OUT
Console.WriteLine($"O valor calculado do perimetro eh: " + perimetro);
Console.WriteLine($"O valor calculado do area eh: " + area);

Console.WriteLine("\n\n========== PASSANDO ARGUMENTOS NOMEADOS======================");
// chamando um metodo com argumentos NOMEADOS
var email = new Email();
email.Enviar(destino: "email@email.com", titulo: "Negocios", assunto: "como esta o relatorio?");
email.Enviar(assunto: "ola como vai voce?", destino: "teste@teste.com", titulo: "boas vindas");
// chamando um metodo que tem parametros opcionais (ou parametros padroes)
Console.WriteLine("\n\n========== PASSANDO ARGUMENTOS NOMEADOS======================");
email.EnviarPadrao("testando@teste.com");
email.EnviarPadrao("testando@teste1.com", titulo: "ola");
email.EnviarPadrao("testando@teste2.com", "hello world!");


public class Circulo // usando o OUT
{
    public double CalcularPerimetroArea(double raio, out double area)
    {
        area = Math.PI * Math.Pow(raio, 2);
        double perimetro = 2 * Math.PI * raio;
        return perimetro;
    }
}
public class Calcular // usando o REF
{
    public void Dobrar(int y)  // metodo passando argumento por VALOR
    {
        y *= 2;
        Console.WriteLine($"Valor do parametro y = {y}");
    }
    public void Dobrar2(ref int y) // metodo passando argumento por REFERENCIA
    {
        y *= 2;
        Console.WriteLine($"Valor do parametro y = {y}");
    }
}

public class Email // funcao para argumentos nomeados
{
    public void Enviar(string destino, string assunto, string titulo)
    {
        Console.WriteLine($"Para {destino} - {titulo} : \n\t{assunto}\n");
    }
    // metodo com parametros pre definidos (parametros padroes / opcionais)
    public void EnviarPadrao(
        string destino,
        string assunto = "assunto padrao",
        string titulo = "titulo padrao")
    {
        Console.WriteLine($"Para {destino} - {titulo} : \n\t{assunto}\n");
    }
}