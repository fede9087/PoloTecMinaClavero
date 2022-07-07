/* Crear una clase Billetera que tenga las siguientes propiedades públicas del tipo entero:

BilletesDe10
BilletesDe20
BilletesDe50
BilletesDe100
BilletesDe200
BilletesDe500
BilletesDe1000

Agregar un método que se llame Total del tipo decimal, y que devuelva el Importe Total en la billetera teniendo en cuenta la cantidad de billetes que se tenga de cada tipo.

Agregar un metodo que se llame Combinar, que reciba como parámetro otra billetera y que devuelva una nueva Billetera con la suma o combinacion del dinero de ambas billeteras.  
Una vez combinadas las 2 billeteras (y creada la tercera), las 2 primeras billeteras deberan quedar en cero. (Sin billetes)
*/
using Ejercicio7.Modelo;

var b1 = new Ejercicio7.Modelo.Billetera();
var b2 = new Ejercicio7.Modelo.Billetera();

b1.BilletesDe100 = 2;
b1.BilletesDe200 = 1;

b2.BilletesDe1000 = 2;


Console.WriteLine($"Total de la billetera N° 1 ${b1.Total().ToString()}");
Console.WriteLine($"Total de la billetera N° 2 ${b2.Total().ToString()}");

var b3 = b1.Combinar(b2);
Console.WriteLine($"Total de las 2 billetera ${b3.Total().ToString()}");
Console.WriteLine($"Nuevo valor billetera N° 1 ${b1.Total().ToString()}");
Console.WriteLine($"Nuevo valor billetera N° 2 ${b2.Total().ToString()}");

