﻿/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */



    class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите значение N: ");
        int N = int.Parse(Console.ReadLine());

        PrintNumbers(N);
        
        Console.ReadKey();
    }
    static void PrintNumbers(int num)
    {
        if (num == 0)
            return;
            
        System.Console.Write(num + ", ");
        
        if (num != 1) 
            PrintNumbers(--num);  
    }
}