// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение M: ");
        if (int.TryParse(Console.ReadLine(), out int m))
        {
            Console.Write("Введите значение N: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n >= m)
            {
                Console.WriteLine($"Натуральные числа в промежутке от {m} до {n}:");
                PrintNaturalNumbersInRange(m, n);
            }
            else
            {
                Console.WriteLine("Некорректный ввод для N. Пожалуйста, введите целое число больше или равное M.");
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод для M. Пожалуйста, введите целое число.");
        }
    }

    static void PrintNaturalNumbersInRange(int m, int n)
    {
        if (m <= n)
        {
            Console.WriteLine(m);
            PrintNaturalNumbersInRange(m + 1, n);
        }
    }
}
 
 
 //Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

 using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число m: ");
        if (int.TryParse(Console.ReadLine(), out int m) && m >= 0)
        {
            Console.Write("Введите число n: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n >= 0)
            {
                int result = AckermannFunction(m, n);
                Console.WriteLine($"Значение функции Аккермана для m={m}, n={n}: {result}");
            }
            else
            {
                Console.WriteLine("Некорректный ввод для n. Пожалуйста, введите неотрицательное целое число.");
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод для m. Пожалуйста, введите неотрицательное целое число.");
        }
    }

    static int AckermannFunction(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return AckermannFunction(m - 1, 1);
        }
        else if (m > 0 && n > 0)
        {
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        }
        else
        {
            return -1; // Возвращаем -1 для случая некорректных входных данных
        }
    }
}


//Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        Console.WriteLine("\nМассив, выведенный с конца:");
        PrintArrayReverse(array, array.Length - 1);
    }

    static void PrintArray(int[] array, int index = 0)
    {
        if (index < array.Length)
        {
            Console.Write(array[index] + " ");
            PrintArray(array, index + 1);
        }
    }

    static void PrintArrayReverse(int[] array, int index)
    {
        if (index >= 0)
        {
            Console.Write(array[index] + " ");
            PrintArrayReverse(array, index - 1);
        }
    }
}
