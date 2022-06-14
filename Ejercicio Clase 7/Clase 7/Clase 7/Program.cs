// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.Clear();
int[] numero = new int[10];


for (int i = 0; i < 10; i++) 
{
    Console.WriteLine($"{i+1}-Por favor ingrese un numero:");
    numero[i] = int.Parse(Console.ReadLine());

}
int contador=0;
for (int i = 0; i < numero.Length; i++)
    contador += numero[i]; 
Console.WriteLine($"La suma de los numeros es { contador}");
int promedio = contador / numero.Length;
Console.WriteLine($"El promedio es : {promedio}");

int numeroMayor = 0;

 for(int i = 0; i < numero.Length; i++)
{
    if(numero[i] > numeroMayor)
    {
        numeroMayor=numero[i];
      
    }
   
    

}

int numeroMenor = numeroMayor;
for (int i = 0; i < numero.Length; i++)
{

    if (numero[i] < numeroMenor)
    {
        numeroMenor = numero[i];
    }
}
Console.WriteLine($"El numero mayor es {numeroMayor}");
Console.WriteLine($"El numero menor es {numeroMenor}");

for (int i = 0; i < numero.Length; i++)
{
    Console.WriteLine($"Numero ingresado {numero[i]}");
}







