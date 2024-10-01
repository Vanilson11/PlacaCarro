using System.Numerics;

namespace PlacaCarro;
public class CriarPlaca
{
    private string NumeroPlaca;
    private char[] PlacaCompleta = new char[7];
    public CriarPlaca(string placa)
    {
        this.NumeroPlaca = placa;
    }

    public void VerificarTamanhoPlaca()
    {
        if (NumeroPlaca.Length == 0 || NumeroPlaca.Length > 7)
        {
            Console.WriteLine("ERRO. A placa precisa ter 7 caracteres alfanuméricos.");
        }
    }

    public void VerificarLetras()
    {
        for (int i = 0; i < 3; i++)
        {
            bool isNumber = char.IsNumber(NumeroPlaca[i]);
            if (isNumber)
            {
                Console.WriteLine("ERRO. Os 3 primeiros caracteres da placa devem ser letras(maiúsculas ou minúsculas).");
                break;
            }
            PlacaCompleta[i] = NumeroPlaca[i];
        }
    }

    public void VerificarNumeros()
    {
        for (int i = 3; i < 7; i++)
        {
            bool isNumber = char.IsNumber(NumeroPlaca[i]);
            if (!isNumber)
            {
                Console.WriteLine("ERRO. A placa deve finalizar com 4 números.");
                break;
            }
            PlacaCompleta[i] = NumeroPlaca[i];
        }
    }

    public string ExibirPlaca()
    {
        string PlacaCompletaTexto = string.Join("", PlacaCompleta);
        return PlacaCompletaTexto;
    }
}
