
Console.WriteLine("Escribe un número para encontrar su suma y factorial mediante recursividad");
int i = int.Parse(Console.ReadLine());

Console.Write("\nSUMA: ");
Console.Write(suma(i));

Console.Write("\nFACTORIAL: ");
Console.WriteLine(factorial(i));


static int suma (int n)
{
    if (n == 1)
    {
        return n;
    }
    else
    {
        return n + suma(n - 1);
    }
}

static int factorial (int n)
{
    if (n==1)
    {
        return n;
    }
    else
    {
        return n * factorial(n - 1);
    }
}


 