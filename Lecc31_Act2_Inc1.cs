using System;

class Program
{
    static void Main(string[] args)
    {
        int numeroFila, numeroColumna;
        int[,] matrizIdentidad = new int[4, 4];

        // Llenar la matriz
        for (numeroFila = 0; numeroFila < 4; numeroFila++)
        {
            for (numeroColumna = 0; numeroColumna < 4; numeroColumna++)
            {
                if (numeroFila == numeroColumna)
                {
                    matrizIdentidad[numeroFila, numeroColumna] = 1;
                }
                else
                {
                    matrizIdentidad[numeroFila, numeroColumna] = 0;
                }
            }
        }

        // Mostrar la matriz
        Console.WriteLine("Matriz Identidad");

        for (numeroFila = 0; numeroFila < 4; numeroFila++)
        {
            for (numeroColumna = 0; numeroColumna < 4; numeroColumna++)
            {
                Console.Write(matrizIdentidad[numeroFila, numeroColumna] + " ");
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}
