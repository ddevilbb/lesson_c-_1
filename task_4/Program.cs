// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();
Console.WriteLine("Программа, определяющая максимальное число из трёх");

Console.Write("Введите три числа через пробел: ");
int[] numbers = Console.ReadLine()?.Split(' ').Take(3).Select(int.Parse).ToArray()!;

Console.WriteLine("{0} -> {1}", string.Join(", ", numbers), numbers.Max());
