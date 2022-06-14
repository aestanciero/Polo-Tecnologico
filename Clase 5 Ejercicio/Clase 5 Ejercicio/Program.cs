// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var desicion = "S";
while (desicion.ToUpper() =="S") {
    //1) Borrar la pantalla
    Console.Clear();
    //2) Pedir el nombre de una persona.
    Console.WriteLine("Ingrese su nombre: ");
    string nombre;
    nombre = Console.ReadLine();
    //3) Saludarlo con un texto que diga "¡Hola [NombreIngresado]!"
    Console.WriteLine("Hola " + nombre);
    //4) Preguntar si se quiere continuar.
    Console.WriteLine("Desea Continuar? S o N");
     desicion = Console.ReadLine();
}


//6) Si la respuesta es "N" finalizar el programa mostrando un mensaje que diga "Programa finalizado correctamente".
if (desicion.ToUpper() == "N") {
    Console.WriteLine("Programa finalizado correctamente");
}
//7) Si la respuesta no es ni "S" ni "N" que tambien finalice el programa, pero mostrando un mensaje que diga "Opcion no valida"
else
{
    Console.WriteLine("Opcion no valida");

        }



