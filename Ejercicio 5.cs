class Program
{
    static void Main()
    {
        Console.Write("Ingrese el saldo actual: ");
        double saldoActual = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el monto a retirar: ");
        double montoARetirar = Convert.ToDouble(Console.ReadLine());

        saldoActual = RealizarRetiro(saldoActual, montoARetirar);

        Console.WriteLine("Saldo actual: $" + saldoActual);
    }

    public static double RealizarRetiro(double saldo, double retiro)
    {
        if (retiro > saldo)
        {
            Console.WriteLine("Error: saldo insuficiente.");
            return saldo;
        }

        return saldo - retiro;
    }
}
