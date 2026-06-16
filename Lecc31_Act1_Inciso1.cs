internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Diego Trujillo");
        Console.WriteLine("IVC");
        Console.WriteLine("Clave 31");
        int filas = 3;
        int columnas = 5;
        int i = 0; int j = 0;
        int[,]matriz = new int[3,5];

        for ( i = 0; i < filas; i++ )
        {
            for ( j = 0; j < columnas; j++ )
            {
                Console.WriteLine("Ingrese el numero que quiere guardar en la fila : " + i + ",Columna: " + j + " =");
                matriz[i,j] = int.Parse(Console.ReadLine());

                    }
        }
        for(i =0; i < filas ; i++)
        {
            for (j = 0;j < columnas; j++ )
            {
                Console.WriteLine("Fila: "+i+", Columna: "+j+" =" + matriz[i,j]);
            }
        }
    }
}
