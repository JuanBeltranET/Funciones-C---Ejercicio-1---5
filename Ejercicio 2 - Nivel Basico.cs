class Program
{
    static void Main()
    {
        int[] num = { 25, 8, 42, 17, 3, 30, 15, 10 };
        int mayor = num[0];
        int menor = num[0];
        int posMayor = 0;
        int posMenor = 0;
        for (int i = 1; i < num.Length; i++)
        {
            if (num[i] > mayor)
            {
                mayor = num[1];
                posMayor = i;
            }
            if (num[i] < menor)
            {
                menor = num[i];
                posMenor = i;
            }
        }
        Console.WriteLine("Mayor: " + mayor);
        Console.WriteLine("Posicion del mayor: " + posMayor);
        Console.WriteLine("Menor: " + menor);
        Console.WriteLine("Posicion del mayor: " + posMenor);
    }
}