﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Clear();
Console.WriteLine("Программа, которая на вход принимает число и выдаёт, " +
                  "является ли число чётным (делится ли оно на два без остатка)");

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("{0} -> {1}", number, (number % 2 == 0 ? "да" : "нет"));
