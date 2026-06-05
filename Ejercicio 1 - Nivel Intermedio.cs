class Program
{
    static void InvertirArray(string[] nombres)
    {
        int inicio = 0;
        int fin = nombres.Length - 1;
        while (inicio < fin)
        {
            string iniciotemp = nombres[inicio]; // guardo temporalmente un valor para poder intercambiar
            nombres[inicio] = nombres[fin];
            nombres[fin] = iniciotemp;
            inicio++;
            fin--; // sirven para mover los índices hacia el centro del arreglo despues de cada intercambio
        }
    }
    static void Main()
    {
        string[] nombres = { "Juan", "Demian", "Alejandro", "Jose", "Anabella", "Gabriel", "Ivo", "Isaias", "Leonardo", "Matias", "Lautaro", "Nico", "Franco", "Tiziano" };
        InvertirArray(nombres);
        foreach (string nombre in nombres)
        {
            Console.WriteLine(nombre);
        }
    }
}