class Program
{
    static void Main()
    {
        Console.Write("Ingrese el radio del círculo: ");

        if (double.TryParse(Console.ReadLine(), out double radio))
        {
            double area = CalcularAreaCirculo(radio);
            ImprimirResultado("EL ÁREA DEL CÍRCULO ES", area);
        }
        else
        {
            Console.WriteLine("Entrada inválida");
        }
    }

    public static double CalcularAreaCirculo(double radio)
    {
        return Math.PI * Math.Pow(radio, 2);
    }

    public static void ImprimirResultado(string texto, double valor)
    {
        Console.WriteLine($"--- {texto}: {Math.Round(valor, 2)} ---");
    }
}