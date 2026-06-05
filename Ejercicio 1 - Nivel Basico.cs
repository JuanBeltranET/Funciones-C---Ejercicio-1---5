class Program
{
    static void Main()
    {
        int[] num = { 5, 8, 12, 3, 7, 10, 15, 6, 9, 4 };
        int suma = 0;
        for (int i = 0; i < num.Length; i++)
        {
            suma = suma + num[i];
        }
        double promedio = (double)suma / num.Length;
        Console.WriteLine("Suma: " + suma);
        Console.WriteLine("Promedio: " + promedio);
    }
}