// 1: Imprimir valores del 1 al 255
for (int i = 1; i <= 255; i++)
{
    Console.WriteLine(i);
}

//while
int j = 1;
while (j <= 255)
{
    Console.WriteLine(j);
    j++;
}

//2: Imprimir valores del 1 al 100 divisibles por 3 o 5 pero no ambos

for (int i = 1; i <= 100; i++)
{
    if ((i % 3 == 0 || i % 5 == 0) && !(i % 3 == 0 && i % 5 == 0))
    {
        Console.WriteLine(i);
    }
}

//while
while (j <= 100)
{
    if ((j % 3 == 0 || j % 5 == 0) && !(j % 3 == 0 && j % 5 == 0))
    {
        Console.WriteLine(j);
    }
    j++;
}

//3: Imprimir "Fizz" para múltiplos de 3, "Buzz" para múltiplos de 5 y "FizzBuzz" para múltiplos de ambos

for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}

//while

while (j <= 100)
{
    if (j % 3 == 0 && j % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (j % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (j % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(j);
    }
    j++;
}




