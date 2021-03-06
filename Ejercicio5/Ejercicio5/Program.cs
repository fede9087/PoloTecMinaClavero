/* Con los conocimientos vistos hasta ahora en clase realizar un programa que haga lo siguiente:

1)      Pedir al usuario la longitud de un vector
2)      Crear el vector del tamaño ingresado.
3)      Llenar el mismo con datos aleatorios
4)      Mostrar el vector por pantalla
5)      Invertir el vector, de manera que el primer elemento quede al último y el útimo en el primero; el segundo en anteúltimo, el anteúltimo en el segundo y así sucesivamente. En otra palabras si el vector es de 5 posiciones y el usuario ingresó: 10, 20, 30, 40, 50, una vez invertido, el vector debe quedar así: 50, 40, 30, 20, 10.
Se debe usar solo lo visto en clase hasta ahora y no los métodos que trae C# para estas cuestiones. Tampoco se debe crear un vector nuevo o auxiliar para realizar el ejercicio. 
6)      Mostrar el vector nuevamente.
*/

// 1)Pedir al usuario la longitud de un vector
Console.WriteLine("Ingrese el tamaño deseado para el listado:");
int lista = int.Parse(Console.ReadLine());

// 2)Crear el vector del tamaño ingresado.
int[] vector = new int[lista];

// 3)Llenar el mismo con datos aleatorios
Random aleatorio = new Random();
for(int i = 0; i < vector.Length; i++)
{
    vector[i] = aleatorio.Next(50);
}

// 4)Mostrar el vector por pantalla
var contador = 0;
foreach(int i in vector)
{
    contador++;
    Console.WriteLine($"{contador}°){i}");
}
// 5) Invertir el vector
Console.WriteLine();
contador = 0;
for (int i = lista-1; i >= 0; i--)
{
    contador++;
    // 6) Mostrar el vector
    Console.WriteLine($"{contador}°){vector[i]}");
}