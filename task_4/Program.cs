﻿// Задача 4: Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("ВВедите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ВВедите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ВВедите третье число:");
int number3 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2 && number1 > number3)
{
    Console.WriteLine($"max = {number1}");
}
else if (number2> number1 && number2 > number3)
{
    Console.WriteLine($"max = {number2}");
}
else if (number3> number1 && number3 > number2)
{
    Console.WriteLine($"max = {number3}");
}
else
{
    Console.WriteLine("Введены не корректные значения");
}
