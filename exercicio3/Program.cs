internal class Program
{
    static string ValorMaisProximoDeZero(List<int> numeros)
    {
        if (numeros.Count == 0) return "Lista vazia";

        bool nenhum = false;
        int maisProximo = numeros[0];
        int distanciaDoZero = Math.Abs(maisProximo);

        foreach (int numero in numeros)
        {
            if(Math.Abs(numero) < distanciaDoZero)
            {
                maisProximo = numero;
                distanciaDoZero = Math.Abs(numero);
                nenhum = false;
            } else if(Math.Abs(numero) == distanciaDoZero && numero != maisProximo) nenhum = true;
        }

        if (nenhum) return "Nenhum";

        return maisProximo.ToString();
    }

    static void Main(string[] args)
    {
        List<int> listaNumeros = new List<int>();
        int[] numeros = { 13, 0, -6};
        listaNumeros.AddRange(numeros);
        Console.WriteLine(ValorMaisProximoDeZero(listaNumeros));
    }
}