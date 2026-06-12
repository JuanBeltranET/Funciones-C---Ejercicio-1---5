class Program
{
    static void Main()
    {
        int filas = 4;
        int columnas = 6;
        int[,] matriz = new int[filas, columnas];
        int secuencia = 2; // conteo de dos en dos

        for (int f = 0; f < filas; f++)
        {
            for (int c = 0; c < columnas; c++)
            {
                if (c % 2 == 0) // para cambiar las columnas pares en 0
                {
                    matriz[f, c] = 0;
                }
                else
                {
                    matriz[f, c] = secuencia;
                    secuencia += 2; // para incrementar de dos en dos para el siguiente número par
                }
            }
        }
        Console.WriteLine("Matriz resultante:");
        for (int c = 0; c < columnas; c++)
        {
            Console.WriteLine(matriz[f, c] + "\t");
        }
        Console.WriteLine();
    }
}