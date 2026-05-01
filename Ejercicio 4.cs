class Program
{
    static void Main()
    {
        Console.Write("Ingrese el primer número: ");
        int.TryParse(Console.ReadLine(), out int a);
        Console.Write("Ingrese el segundo número: ");
        int.TryParse(Console.ReadLine(), out int b);
        Console.Write("Ingrese el tercer número: ");
        int.TryParse(Console.ReadLine(), out int c);
        int maximo = ObtenerMaximo(a, b, c);
        Console.WriteLine($"El número mayor es: {maximo}");
    }

    public static int ObtenerMaximo(int a, int b, int c)
    {
        if (a >= b && a >= c)
            return a;
        else if (b >= a && b >= c)
            return b;
        else
            return c;
    }
}