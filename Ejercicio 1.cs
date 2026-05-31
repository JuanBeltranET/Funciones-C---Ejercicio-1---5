using System;
class Program
{
    static int ProductoEscalar(int[] array1, int[] array2)
    {
        int suma = 0;
        for (int i = 0; i < array1.Length; i++)
        {
            suma += array1.Length * array2[i];
        }
        return suma;
    }

    static int[] InvertirArray(int[] array)
    {
        int[] invertido = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            invertido[i] = array[array.Length - 1 - i];
        }
        return invertido;
    }

    static int ProductoEscalarConInverso(int[] array1, int[] array2)
    {
        int[] arrayInvertido = InvertirArray(array2);
        return ProductoEscalar(array1, arrayInvertido);
    }

    static void Main()
    {
        int[] a = { 1, 2, 3 };
        int[] b = { 4, 5, 6 };
        int resultado = ProductoEscalarConInverso(a, b);
        Console.WriteLine("Producto escalar con inverso: " + resultado);
    }
}