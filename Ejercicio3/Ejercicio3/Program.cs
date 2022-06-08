/*Escribe un programa que:

1) Pida 10 números al usuario.
2) Obtener la suma de todos los números ingresados.
3) Obtener cual es el mayor de todos los números.
4) Obtener cual es el menor de todos los números.
5) Obtener el promedio de todos los números.
6) Mostrar todos los números ingresados por pantalla.
7) Mostrar los valores calculados en los puntos 2, 3, 4 y 5.
*/

Console.Clear();
//1) Pida 10 números al usuario.
int[] numeros = new int[10];
Console.WriteLine("Por favor ingrese 10 numeros");
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Ingrese el numero: {i + 1}");
    numeros[i] = int.Parse(Console.ReadLine());
}
//2) Obtener la suma de todos los números ingresados.
int suma = 0;
for (int i = 0; i < numeros.Length; i++)
{
    suma += numeros[i];
}
//3) Obtener cual es el mayor de todos los números.

int mayor = numeros[0];
for (int i = 1; i < numeros.Length; i++)
    if (numeros[i] > mayor)
    {
        mayor = numeros[i];
    }

//4) Obtener cual es el menor de todos los números.

int menor = numeros[0];
for (int i = 1; i < numeros.Length; i++)
    if (numeros[i] < menor)
    {
        menor = numeros[i];
    }

//5) Obtener el promedio de todos los números.

double sumaDouble = suma; //Convertir un int a double para la division y obtener el valor totale en double
double promedio = sumaDouble / numeros.Length;

//6) Mostrar todos los números ingresados por pantalla.
Console.WriteLine($"Los numeros ingresados son:");
for (int i = 0; i < numeros.Length; i++)
{
    Console.Write(numeros[i] + ", ");
}
Console.WriteLine();
//7) Mostrar los valores calculados en los puntos 2, 3, 4 y 5.
//Valor punto 2
Console.WriteLine($"La suma de todos los numeros es: {suma}");
//Valor punto 3
Console.WriteLine($"El numero mayor es: {mayor}");
//Valor punto 4
Console.WriteLine($"El numero menor es: {menor}");
//Valor punto 5
Console.WriteLine($"El promedio es: {promedio}");