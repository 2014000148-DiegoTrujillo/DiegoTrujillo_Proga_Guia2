using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] edades = new int[3, 3];

        // Ingresar edades
        for (int fila = 0; fila < 3; fila++)
        {
            for (int columna = 0; columna < 3; columna++)
            {
                Console.Write("Ingrese la edad del alumno [" + (fila + 1) + "," + (columna + 1) + "]: ");
                edades[fila, columna] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\nMatriz de edades:\n");

        // Mostrar edades y si son mayores de edad
        for (int fila = 0; fila < 3; fila++)
        {
            for (int columna = 0; columna < 3; columna++)
            {
                if (edades[fila, columna] >= 18)
                {
                    Console.Write(edades[fila, columna] + " (Mayor)\t");
                }
                else
                {
                    Console.Write(edades[fila, columna] + " (Menor)\t");
                }
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nPresione una tecla para salir...");
        Console.ReadKey();
    }
}
