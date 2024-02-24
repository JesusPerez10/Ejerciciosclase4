
{
    Console.WriteLine("Los primeros numeros 5 numero pares son:");

    for (int i = 2; i <= 10; i += 2)
        Console.WriteLine(i);

    int suma = 0;
    for (int i = 1; i <= 10; i++)
    {
        suma += i;

    }
    Console.WriteLine("La suma de los primeros 10 numeros es:" + suma);

    int suma2 = 0;
    int numero;

    Console.WriteLine("Ingrese números enteros positivos. Ingrese un número negativo para finalizar.");

    do
    {
        Console.Write("Ingrese un número: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out numero))
        {
            if (numero >= 0)
            {
                suma2 += numero;
            }
            else
            {
                Console.WriteLine("Número negativo ingresado. Finalizando la entrada de datos.");
            }
        }
        else
        {
            Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
        }

    } while (numero >= 0);

    Console.WriteLine("La suma de los números ingresados es: " + suma2);


    Console.WriteLine("Buscando el primer número entero positivo divisible entre 7 y 11...");

    int numero1 = 1;

    while (true)
    {
        if (EsDivisible(numero1, 7) && EsDivisible(numero1, 11))
        {
            Console.WriteLine($"El primer número divisible entre 7 y 11 es: {numero1}");
            break;
        }

        numero1++;
    }
}

static bool EsDivisible(int numero1, int divisor)
{
    return numero1 % divisor == 0;
}

string contraseñaCorrecta = "jutiapa";
string contraseñaIngresada;

do
{
    Console.Write("Ingrese la contraseña: ");
    contraseñaIngresada = Console.ReadLine();

    if (contraseñaIngresada != contraseñaCorrecta)
    {
        Console.WriteLine("Contraseña incorrecta. Por favor, inténtelo de nuevo.");
    }

} while (contraseñaIngresada != contraseñaCorrecta);

Console.WriteLine("¡Contraseña correcta! Acceso permitido.");


Random generadorAleatorio = new Random();
int numeroAleatorio = generadorAleatorio.Next(1, 101);
int intento;
int intentosRealizados = 0;

Console.WriteLine("Intenta adivinar el número entre 1 y 100.");

do
{
    Console.Write("Ingresa tu intento: ");
    string input = Console.ReadLine();

    if (int.TryParse(input, out intento))
    {
        intentosRealizados++;

        if (intento < numeroAleatorio)
        {
            Console.WriteLine("Demasiado bajo. Intenta de nuevo.");
        }
        else if (intento > numeroAleatorio)
        {
            Console.WriteLine("Demasiado alto. Intenta de nuevo.");
        }
        else
        {
            Console.WriteLine($"¡Correcto! Has adivinado el número {numeroAleatorio} en {intentosRealizados} intentos.");
        }
    }
    else
    {
        Console.WriteLine("Entrada no válida. Por favor, ingresa un número entero.");
    }

} while (intento != numeroAleatorio);
    


