class Program
{
    static void Main()
    {
        char[] letras = { 'a', 'b', 'a', 'c', 'b', 'a', 'd', 'c', 'a', 'b' };

        bool[] contado = new bool[letras.Length];

        for (int i = 0; i < letras.Length; i++)
        {
            if (!contado[i])
            {
                int cantidad = 1;

                for (int j = i + 1; j < letras.Length; j++)
                {
                    if (letras[i] == letras[j])
                    {
                        cantidad++;
                        contado[j] = true;
                    }
                }

                Console.WriteLine("'" + letras[i] + "' aparece " + cantidad + " veces");
            }
        }
    }
}
