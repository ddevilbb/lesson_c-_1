// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
Console.WriteLine("Программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(
    (
        num1 != num2 
        ? $"max={(num1 > num2 ? num1 : num2)} min={(num1 < num2 ? num1 : num2)}" 
        : "Они равны"
    )
);
