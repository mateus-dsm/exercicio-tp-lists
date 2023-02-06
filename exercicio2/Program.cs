internal class Program
{
    static int DiferencaEntreMaiorEMenor(List<int> numeros)
    {
        if(numeros.Count == 0 || numeros.Count == 1) return 0;

        int menor = numeros[0];
        int maior = numeros[0];

        foreach(int numero in numeros)
        {
            if(numero < menor) menor = numero;
            else if(numero > maior) maior = numero;
        }

        return maior - menor;
    }

    static void Main(string[] args)
    {
        List<int> listaNumeros = new List<int>();
        Console.WriteLine(DiferencaEntreMaiorEMenor(listaNumeros));

        listaNumeros.Add(1);
        Console.WriteLine(DiferencaEntreMaiorEMenor(listaNumeros));

        int[] numeros = { 2, -4, 3 };
        listaNumeros.AddRange(numeros);
        Console.WriteLine(DiferencaEntreMaiorEMenor(listaNumeros));
    }
}