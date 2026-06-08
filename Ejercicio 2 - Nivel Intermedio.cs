class Program
{
    static void Main()
    {
        int[] numeros = { 12, 7, 19, 24, 31, 8, 15, 41, 3, 10, 22, 29, 6, 17, 4 };
        int cantidadPrimos = 0;
        for (int i = 0; i < numeros.Length; i++)
        {
            if (EsPrimo(numeros[i]))
            {
                cantidadPrimos++;
            }
        }
        int[] primos = new int[cantidadPrimos];
        int j = 0;
        for (int i = 0; i < numeros.Length; i++)
        {
            if (EsPrimo(numeros[i]))
            {
                primos[j] = numeros[i];
                j++;
            }
        }
        Console.WriteLine("Numeros primos:");
        for (int i = 0; i < primos.Length; i++)
        {
            Console.Write(primos[i] + " ");
        }
    }

    static bool EsPrimo(int numero)
    {
        if (numero < 2)
        {
            return false;
        }
        for (int i = 2; i < numero; i++)
        {
            if (numero % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}
