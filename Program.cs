using System;

class Program
{
    static void Main()
    {
        // Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

        int a = 1;
        Console.Write("a = 1 ");

        
        int b = 8;
        Console.Write("b = 3 ");

        int result = AckermannFunction(a, b);
        Console.WriteLine($"{result}");
    }

    static int AckermannFunction(int a, int b)
    {
        if (a == 0)
        {
            return b + 1;
        }
        else if (b == 0)
        {
            return AckermannFunction(a - 1, 1);
        }
        else
        {
            
            int innerResult = AckermannFunction(a, b - 1);
            return AckermannFunction(a - 1, innerResult);
        }
    }
}
