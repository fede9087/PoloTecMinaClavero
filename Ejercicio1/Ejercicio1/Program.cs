/*Escribir un programa que haga lo siguiente:

1) Borrar la pantalla.
2) Pedir el nombre de una persona.
3) Saludarlo con un texto que diga "¡Hola [NombreIngresado]!"
4) Preguntar si se quiere continuar.
5) Si la respuesta es "S" repetir desde el punto 1.
6) Si la respuesta es "N" finalizar el programa mostrando un mensaje que diga "Programa finalizado correctamente".
7) Si la respuesta no es ni "S" ni "N" que tambien finalice el programa, pero mostrando un mensaje que diga "Opcion no valida".
*/

var respuesta = "S";


while (respuesta.ToUpper() == "S")
{
    // 1° Limpiamos consola
    Console.Clear();


    // 2° Pedimos que ingrese su nombre
    Console.WriteLine("Por favor ingrese su nombre:");
    var nombre = Console.ReadLine();

    //3° mostramos el saludo + el nombre ingresado
    Console.WriteLine($"¡Hola {nombre}!");

    //4° Preguntar si quiere continuar
    Console.WriteLine("¿Desea continuar? (S/N)");
    respuesta = Console.ReadLine();

    if (respuesta.ToUpper() == "S")
    {
        respuesta = "S";
    }
    else if (respuesta.ToUpper() == "N")
    {
        Console.WriteLine("Programa finalizado correctamente");
    }
    else
    {
        Console.WriteLine("Opcion no valida");
    }

}

