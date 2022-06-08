/*Ejercicio

Crear un programa que cumpla con los siguientes pasos

1) Crear una matriz de dos dimensiones de tipo int llamada numeros,
2) Determinar el tamaño de cada dimansion (fila, columnas) mediante valores ingresados por pantalla
3) Declarar un vector de tipo double llamado promedios
4) Recorrer la matriz para su carga con elementos de tipo int
5) Recorrer la matriz para mostrar cada valor de la matriz
6) Calcular el promedio de cada columna y asignarlo a la posicion correspondiente dentro del vector promedios
7) Mostrar los promedios recorriendo el vector promedios
*/

Console.Clear();
//1) Crear una matriz de dos dimensiones de tipo int llamada numeros,
int[,] numeros;

//2) Determinar el tamaño de cada dimansion (fila, columnas) mediante valores ingresados por pantalla
Console.WriteLine("=======================================");
Console.WriteLine();

Console.Write("Ingrese la cantidad de columnas: ");
// Determina las columnas
int cantidadFilas = int.Parse(Console.ReadLine());

Console.WriteLine();

Console.Write("Ingrese la cantidad de filas: ");
// Determina las filas
int cantidadColumnas = int.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("=======================================");
Console.WriteLine();

//3) Declarar un vector de tipo double llamado promedios


//4) Recorrer la matriz para su carga con elementos de tipo int
//Utilizamos recien la matriz creada en el punto 1)
numeros = new int[cantidadColumnas, cantidadFilas];

//Cantidad de filas
int lengthFilas = numeros.GetUpperBound(0) + 1;

//Cantidad de columnas
int lengthColumnas = numeros.GetUpperBound(1) + 1;

//Recorremos columnas
for (int columna = 0; columna < lengthColumnas; columna++)
{
    Console.WriteLine($"Columna N° {columna + 1}: ");

    // Recorremos filas
    for (int fila = 0; fila < lengthFilas; fila++)
    {
        Console.Write($"Cargue el valor de la fila N° {fila + 1}: ");
        numeros[fila, columna] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine();
Console.WriteLine("=======================================");
Console.WriteLine();

//5) Recorrer la matriz para mostrar cada valor de la matriz
// Recorremos las columnas
for (int columna = 0; columna < lengthColumnas; columna++)
{

    Console.WriteLine();
    Console.Write($"Valor de la columna N°: {columna + 1}: ");

    // Recorremos filas
    for (int fila = 0; fila < lengthFilas; fila++)
    {
        Console.Write($" || ");
        Console.Write(numeros[fila, columna]);
    }
}

Console.WriteLine();
Console.WriteLine("=======================================");
Console.WriteLine();
//6) Calcular el promedio de cada columna y asignarlo a la posicion correspondiente dentro del vector promedios

// Recorremos las columnas
for (int columna = 0; columna < lengthColumnas; columna++)
{
    double suma = 0;
    Console.WriteLine();
    Console.Write($"Promedio de la columna N°: {columna + 1}: ");

    // Recorremos filas
    for (int fila = 0; fila < lengthFilas; fila++)
    {
        suma = suma + numeros[fila, columna];
    }
    //7) Mostrar los promedios recorriendo el vector promedios
    for (int promedio = 0; promedio < 1; promedio++)
    {
        double[] promedios = { suma / lengthFilas };

        Console.Write($"|| {promedios[0]} ||");
    }
}

Console.WriteLine();
Console.WriteLine("=======================================");
Console.WriteLine();
