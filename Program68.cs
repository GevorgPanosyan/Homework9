﻿/*Задача 68: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */




class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число m: ");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите число n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Результат функции Аккермана: " + Ackermann(m, n));
    }
    static int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }
}

