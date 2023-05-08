//EJERCICIO1

public static bool EsPalindromo(string palabra)
{
    palabra = palabra.ToLower();
    int longitud = palabra.Length;
    for (int i = 0; i < longitud / 2; i++)
    {
        if (palabra[i] != palabra[longitud - i - 1])
        {
            return false;
        }
    }
    return true;
}

//EJERCICIO2

public static void Fibonacci(int n)
{
    int a = 0, b = 1, c = 0;
    
    Console.Write($"{a}, {b}");

    while (c < n)
    {
        c = a + b;
        if (c < n)
        {
            Console.Write($", {c}");
            a = b;
            b = c;
        }
    }
}

//EJERCICIO4

public static void CalcularEcuacionCuadratica(double a, double b, double c)
{
    double discriminante = b * b - 4 * a * c;

    if (discriminante < 0)
    {
        Console.WriteLine("La ecuación no tiene solución real.");
    }
    else if (discriminante == 0)
    {
        double x = -b / (2 * a);
        Console.WriteLine($"La única solución es x = {x}");
    }
    else
    {
        double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
        double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
        Console.WriteLine($"Las soluciones son x1 = {x1} y x2 = {x2}");
    }
}

//EJERCICIO5

public static void CalcularIMC(double peso, double estatura)
{
    double imc = peso / (estatura * estatura);
    Console.WriteLine("Su IMC es: " + imc.ToString("F"));

    if (imc < 18)
    {
        Console.WriteLine("Peso bajo");
    }
    else if (imc>18 && imc < 24.9)
    {
        Console.WriteLine("Peso normal");
    }
    else if (imc >25 && imc < 26.9)
    {
        Console.WriteLine("Sobrepeso");
    }
    else if (imc > 27)
    {
        Console.WriteLine("Obesidad");
    }
    else if (imc >27 && imc < 29.9)
    {
        Console.WriteLine("Obesidad grado I");
    }
    else if (imc > 30 && imc < 39.9)
    {
        Console.WriteLine("Obesidad de tipo II");
    }
    else
    {
        Console.WriteLine("Obesidad mórbida o extrema");
    }
}