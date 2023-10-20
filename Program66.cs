/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
 натуральных элементов в промежутке от M до N.*/

class Program {
  static void Main (string[] args) {
    Console.WriteLine("Введите M:");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите N:");
    int N = Convert.ToInt32(Console.ReadLine());

    int sum = 0;
    int number = 1;
    while (number <= N) {
      sum += number;
      number++;
    }
    Console.WriteLine($"Сумма натуральных чисел от {M} до {N} равна {sum}");
  }
}
