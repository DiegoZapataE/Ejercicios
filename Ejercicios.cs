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

