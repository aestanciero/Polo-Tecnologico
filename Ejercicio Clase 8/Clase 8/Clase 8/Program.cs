
//1) Crear una matriz de dos dimensiones de tipo int llamada numeros,
//2) Determinar el tamaño de cada dimansion (fila, columnas) mediante valores ingresados por pantalla
//3) Declarar un vector de tipo double llamado promedios
//4) Recorrer la matriz para su carga con elementos de tipo int
//5) Recorrer la matriz para mostrar cada valor de la matriz
//6) Calcular el promedio de cada columna y asignarlo a la posicion correspondiente dentro del vector promedios
//7) Mostrar los promedios recorriendo el vector promedios

Console.WriteLine("Ingrese cantidad de filas");
int cantFilas = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese cantidad de columnas");
int cantColumna = int.Parse(Console.ReadLine());

int[,] numeros = new int[cantFilas, cantColumna];

int lengthFilas = numeros.GetUpperBound(0)+1;
int lengthColumna = numeros.GetUpperBound(1)+1;

for (int i = 0; i < lengthColumna; i++)
{
    Console.WriteLine();
    Console.WriteLine($" A la Columna {i+1}: ");
    for (int j = 0; j < lengthFilas; j++)
    {
        Console.WriteLine();
        Console.WriteLine($"Asigne un  numero a la posicion {j + 1}: ");
        numeros[j, i] = int.Parse(Console.ReadLine());
    }
    
}

for (int i = 0; i < lengthColumna; i++)
{
    Console.WriteLine("*********************");
    Console.WriteLine($"Columna n° {i + 1}");
    for (int j = 0; j < lengthFilas; j++)
    {
        Console.Write($"A la posicion {j + 1} se le asigno el numero:");
        Console.WriteLine(numeros[j,i]);
    }
}

double[] promedios = new double[cantColumna];



for(int columna = 0; columna < lengthColumna; columna++)
{
    double suma = 0;

    for(int fila = 0; fila < lengthFilas; fila++)
    {
        suma=suma + numeros[fila, columna];
        
    }
    promedios[columna] = suma / lengthFilas;
    Console.WriteLine($"El promedio de la columna {columna+1} es: {promedios[columna]}");
}
