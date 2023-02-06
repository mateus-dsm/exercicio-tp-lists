internal class Program
{
    static int[] ContaPositivosSomaNegativos(List<int> numeros)
    {
        int[] contagemESoma = { 0, 0 };

        if (numeros.Count == 0)
        {
            Console.WriteLine("Lista vazia!");
            return contagemESoma;
        }

        foreach(int numero in numeros)
        {
            if (numero > 0) contagemESoma[0]++;
            else if(numero < 0) contagemESoma[1] += numero;
        }

        if (contagemESoma[0] == 0 && contagemESoma[1] == 0) Console.WriteLine("Lista nula!");

        return contagemESoma;
    }

    static void Main(string[] args)
    {
        int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 };
        List<int> listaNumeros = new List<int>();
        listaNumeros.AddRange(numeros);
        int[] contagemESoma = ContaPositivosSomaNegativos(listaNumeros);
        Console.WriteLine(contagemESoma[0]);
        Console.WriteLine(contagemESoma[1]);
    }
}