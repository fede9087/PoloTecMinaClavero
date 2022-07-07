/* Con los conocimientos vistos hasta ahora en clase realizar un programa que haga lo siguiente:

Generar un programa que cree un cartón de bingo aleatorio y lo muestre por pantalla

1)    Cartón de 3 filas por 9 columnas
2)    El cartón debe tener 15 números y 12 espacios en blanco
3)    Cada fila debe tener 5 números
4)    Cada columna debe tener 1 o 2 números
5)    Ningún número puede repetirse
6)    La primer columna contiene los números del 1 al 9, la segunda del 10 al 19, la tercera del 20 al 29, así sucesivamente hasta la última columna la cual contiene del 80 al 90
7)    Mostrar el carton por pantalla
*/

var generadorRandom = new Random();
var carton = new int[3, 9];
// Generar los numero aleatorios para el carton.
for (int c = 0; c < 9; c++)
{
    for (int f = 0; f < 3; f++)
    {
        int nuevoNumero = 0;
        bool numeroNuevoEncontrado = false;
        // Definimos si el numero es nuevo o esta repetido.
        while (!numeroNuevoEncontrado)
        {
            if (c == 0) // Columna 1
            {
                nuevoNumero = generadorRandom.Next(1, 10); // Generaar el numero del 1 al 9.
            }
            else if (c == 8) // Columna 9
            {
                nuevoNumero = generadorRandom.Next(80, 91); // Generaar el numero del 80 al 90.
            }
            else // todas las demas columnas
            {
                nuevoNumero = generadorRandom.Next(c * 10, c * 10 + 10); // Columnas del 2 al 8
            }

            // Buscamos si el nuevoNumero existe en la columna.
            numeroNuevoEncontrado = true;
            for (int f2 = 0; f2 < 3; f2++)
            {
                if (carton[f2, c] == nuevoNumero)
                {
                    numeroNuevoEncontrado = false;
                    break;
                }
            }
            // Si sale del buckle y no encontro repetidos, numeroNuevoEncontrado es true y sale del bucle while.
        }
        carton[f, c] = nuevoNumero;
    }
}

// Ordenar las columnas
for (int c = 0; c < 9; c++)
{
    for (int f = 0; f < 3; f++)
    {
        for (int k = f + 1; k < 3; k++)
        {
            if (carton[f, c] > carton[k, c])
            {
                int aux = carton[f, c];
                carton[f, c] = carton[k, c];
                carton[k, c] = aux;
            }
        }
    }
}

var numeroBorrados = 0;
while (numeroBorrados < 12)
{
    var filaABorrar = generadorRandom.Next(0, 3);
    var columnaABorrar = generadorRandom.Next(0, 9);

    if (carton[filaABorrar, columnaABorrar] == 0)
    {
        continue;
    }

    // Contar los vacios en la fila.
    var vaciosEnFilas = 0;
    for (int c = 0; c < 9; c++)
    {
        if (carton[filaABorrar, c] == 0)
        {
            vaciosEnFilas++;
        }

    }
    // Contar los vacios en la columna.
    var vaciosEnColumna = 0;
    for (int f = 0; f < 3; f++)
    {
        if (carton[f, columnaABorrar] == 0)
        {
            vaciosEnColumna++;
        }
    }
    // Contar los item que tenemos en cada columna.
    var itemsPorcolumna = new int[9];
    for (int c = 0; c < 9; c++)
    {
        for (int f = 0; f < 3; f++)
        {
            if (carton[f, c] != 0)
            {
                itemsPorcolumna[c]++;
            }
        }

    }
    // Contar cuantas columna hay con un solo numero.
    var columnasConUnSoloNumero = 0;
    for (var c = 0; c < 9; c++)
    {
        if (itemsPorcolumna[c] == 1)
        {
            columnasConUnSoloNumero++;
        }
    }
    // Si ya hay 4 ceros en la fila o si ya hay 2 ceros en la columna, no se hace nada.
    if (vaciosEnFilas == 4 || vaciosEnColumna == 2)
        continue;
    // si hay 3 columnas con 1 solo numero, a partir de ahora debo borrar solo las columnas que tienen 3 items
    if (columnasConUnSoloNumero == 3 && itemsPorcolumna[columnaABorrar] != 3)
    {
        continue;
    }
    // Si no entro por las opciones anteriores, borramos el numero
    carton[filaABorrar, columnaABorrar] = 0;
    numeroBorrados++;

}
    // Mostrar carton.
    Console.WriteLine("----------------------------------------------");
for (int f = 0; f < 3; f++)
{
    for (int c = 0; c < 9; c++)
    {
        if (c == 0)
            Console.Write("|");
            if (carton[f, c] == 0) // si es cero, mostramos espacios
                Console.Write("    |");
            else
                Console.Write($" {carton[f, c]:00} |");
    }
    Console.WriteLine();
}
Console.WriteLine("----------------------------------------------");
Console.WriteLine();