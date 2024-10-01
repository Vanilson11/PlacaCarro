namespace PlacaCarro;

public class Program
{
    public static void Main()
    {
        CriarPlaca placa1 = new CriarPlaca(Console.ReadLine());

        placa1.VerificarTamanhoPlaca();
        placa1.VerificarLetras();
        placa1.VerificarNumeros();

        Console.WriteLine($"A placa informada '{placa1.ExibirPlaca()}' está correta!");
    }
}
