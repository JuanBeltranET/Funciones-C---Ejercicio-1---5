/*Ejercicio 2:
Escribir una función/método llamado busquedaL que toma un arreglo de enteros y un
entero. Si el entero se encuentra entre los elementos del arreglo, el método debe devolver
la posición en la que se encuentra, caso contrario debe devolver un valor que permita
identificar a quien llama a la función/método que el entero no se encuentra en el arreglo.
*/

using System;
class Program
{
    static int busquedaL(int[] array, int num)
    {
        for (int i = 0; i < array.Length; i++) // Para dar valor a la posicion.
        {
            if (array[i] == num) // Esto compara cada elemento del arreglo con el numero buscado.
            {
                return i; // Aca devuelve la posición donde encontro el numero. 
            }
        }
        return -1; /* Esto si no se encuentra el arreglo con el
                      numero buscado y terminaria en el else*/
    }
    static void Main()
    {
        int[] num = { 5, 8, 12, 20, 30 };
        Console.Write("Ingrese un numero para buscar: ");
        int numbuscado;
        int.TryParse(Console.ReadLine(), out numbuscado);
        int total = busquedaL(num, numbuscado); /* Empieza a ejecutar el metodo para buscar el numero
                                                   y guardar la respuesta en total */

        if (total != -1) 
        {
            Console.WriteLine("El numero esta en la posicion " + total);
        }
        else
        {
            Console.WriteLine("El numero no se encuentra en el arreglo");
        }
    }
}