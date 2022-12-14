Console.WriteLine("Buenas tienes que adivinar un numero entre el 1 y el 15, ¿Cuál eliges?");
var generadorAleatorio = new Random();
int numero = generadorAleatorio.Next(1, 15);
string numeroadivinado = Console.ReadLine();
int numeroadivinado1 = Int32.Parse(numeroadivinado);
int vida = 3;

if (numeroadivinado1 == numero)
{
    for (int i = 1; i < 2; i++)
    {
        Console.WriteLine("¡Felicidades, has ganado!");
        if (i == 2) ;
        break;
    }
}

for (int bucle = 0; bucle < 3; bucle++)
{
    if (numeroadivinado1 > numero)
    {
        vida = vida-1;
        Console.WriteLine($"Lo siento, te quedan {vida} vidas");
        Console.WriteLine("Tu numero era mayor al que yo pensaba");
    }
    if (numeroadivinado1 < numero)
    {
        
        Console.WriteLine($"Lo siento, te quedan {vida} vidas");
        Console.WriteLine("Tu numero es menor al que yo pensaba");
        vida = vida-1;

    }
    
    if (numeroadivinado1 != numero)
    {
        Console.WriteLine("Introduce otro numero : ");
         numeroadivinado = Console.ReadLine();
         numeroadivinado1 = Int32.Parse(numeroadivinado);
        Console.WriteLine($" Te quedan estos intentos {vida}");
        vida = vida-1;
        
    }
    if (numeroadivinado1 == numero)
    {
        Console.WriteLine($"HAS GANADO!!! EL NUMERO ERA {numero}");
        break;



    }
    if (vida < 0)
    {
        Console.WriteLine($"Lo siento, has perdido el número era {numero}");
        break;
    }
    
    
}
