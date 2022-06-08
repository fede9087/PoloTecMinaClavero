/* Ejercicio N° 2 - Clase N°6
1) Generar un número secreto
aleatorio con la siguiente instruccion:

// Genera un numero entero aleatorio de 1 a 20
int numeroSecreto = new
Random(DateTime.Now.Millisecond).Next(1, 21);

2) Pedir al usuario que ingrese un número y que
intente adivinar el número que eligió la computadora.

3) Si el numero ingresado por el usuario es mayor
al número secreto, avisarle que es muy grande y que intente de nuevo y que
vuelva al paso 2.

4) Si el numero ingresado es menor al número
secreto, avisarle que es muy chico, y que intente de nuevo volviendo al paso 2.

5) Si el número ingresado coincide con el número
secreto, sacar el siguiente mensaje:

"Felicitaciones, has adivinado el número
secreto que era:  [numeroSecreto]"
"Lo has logrado en [n] intentos!!"

Y finalizar el programa.
*/
int numeroIngresado;
int contador = 0;
int numeroSecreto = new
Random(DateTime.Now.Millisecond).Next(1, 21);

do
{
    // 2) Pedir al usuario que ingrese un número y que intente adivinar el número que eligió la computadora.
    Console.WriteLine("Ingrese un numero");
    numeroIngresado = int.Parse(Console.ReadLine());

    // 3) Si el numero ingresado por el usuario es mayor al número secreto, avisarle que es muy grande y que intente de nuevo y que vuelva al paso 2.
    if (numeroIngresado > numeroSecreto)
    {
        Console.WriteLine("El numero que ingreso es muy grande. Intentelo otra vez");
    }
    //4) Si el numero ingresado es menor al número
    // reparar termina el proceso pero muestra el mensaje probar otro metodo
    else if (numeroIngresado < numeroSecreto)
    {
        Console.WriteLine("El numero que ingreso es muy chico. Intentelo otra vez");
    }
    contador++;
}
while (numeroSecreto != numeroIngresado);

// 5) Si el número ingresado coincide con el número
Console.WriteLine($"Felicitaciones, has adivinado el número secreto que era: {numeroSecreto}");
Console.WriteLine($"Lo has logrado en {contador} intentos!!");
