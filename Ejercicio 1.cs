class Program
{
    static void Main()
    {
        Console.Write("Ingrese su edad: ");

        if (int.TryParse(Console.ReadLine(), out int edad))
        {
            bool esMayor = EsMayorDeEdad(edad);

            if (esMayor)
                Console.WriteLine("Es mayor de edad");
            else
                Console.WriteLine("Es menor de edad");
        }
        else
        {
            Console.WriteLine("Entrada inválida");
        }
    }

    public static bool EsMayorDeEdad(int edad)
    {
        return edad >= 18;
    }
}