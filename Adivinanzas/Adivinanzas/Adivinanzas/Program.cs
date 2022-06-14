// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.Clear();
// Genera un numero entero aleatorio de 1 a 20
int numeroSecreto = new
Random(DateTime.Now.Millisecond).Next(1, 21);

Console.WriteLine("Ingresa un numero del 1 al 20");
int miNumero = int.Parse(Console.ReadLine());


var i = 1;

while (miNumero != numeroSecreto)
    {
    i++;





    if (miNumero > numeroSecreto)
        {
            Console.WriteLine("El numero elegido es mayor, intenta de nuevo");
            Console.WriteLine("Ingresa un numero del 1 al 20");
            miNumero = int.Parse(Console.ReadLine());

        };
        if (miNumero < numeroSecreto)
        {
            Console.WriteLine("El numero elegido es menor, intenta de nuevo");
            Console.WriteLine("Ingresa un numero del 1 al 20");
            miNumero = int.Parse(Console.ReadLine());
        };


   

    if (miNumero == numeroSecreto)
    {
    

            Console.WriteLine($"Felicitaciones acertaste el numero elegido era {numeroSecreto}, se realizo en {i} intentos");
        }
    
    
}
    



