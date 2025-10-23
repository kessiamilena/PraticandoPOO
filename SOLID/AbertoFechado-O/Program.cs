namespace AbertoFechado_O;

class Program
{
    static void Main(string[] args)
    {
        Desconto d1 = new DescontoNatal();
        Desconto d2 = new DescontoBlackFriday();

        // :C ou .ToString("C") traz o formato monetário do sistema.
        // C de Currency - moeda em inglês
        Console.WriteLine($"Natal: {d1.Calcular(1000):C}");
        Console.WriteLine($"Black Friday: {d2.Calcular(1000).ToString("C")}");
        Console.WriteLine($"Black Friday: {d2.Calcular(2000)}");
    }
}
