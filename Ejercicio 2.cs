class Program
{
    static void Main()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n--- CONVERSOR DE TEMPERATURAS ---");
            Console.WriteLine("1. Celsius a Fahrenheit");
            Console.WriteLine("2. Fahrenheit a Celsius");
            Console.WriteLine("0. Salir");
            Console.Write("Elija una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Opción inválida");
                continue;
            }

            if (opcion == 1)
            {
                Console.Write("Ingrese grados Celsius: ");

                if (double.TryParse(Console.ReadLine(), out double c))
                {
                    double f = CelsiusAFahrenheit(c);
                    Console.WriteLine($"Equivale a {f} °F");
                }
                else
                {
                    Console.WriteLine("Entrada inválida");
                }
            }
            else if (opcion == 2)
            {
                Console.Write("Ingrese grados Fahrenheit: ");

                if (double.TryParse(Console.ReadLine(), out double f))
                {
                    double c = FahrenheitACelsius(f);
                    Console.WriteLine($"Equivale a {c} °C");
                }
                else
                {
                    Console.WriteLine("Entrada inválida");
                }
            }

        } while (opcion != 0);

        Console.WriteLine("Programa finalizado");
    }

    public static double CelsiusAFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }
    public static double FahrenheitACelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }
}