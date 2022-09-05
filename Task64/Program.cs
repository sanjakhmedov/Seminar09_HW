﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Enter the number: ");
int n = Convert.ToInt32(Console.ReadLine());

void NaturanNumsToN(int num)
{
    if (num == 1)
    {
        Console.Write($"{num} ");
        return;
    }
    if (n > 1)
    {
        Console.Write($"{num}, ");
        NaturanNumsToN(num - 1);
    }
    else
    {
        Console.Write($"{num}, ");
        NaturanNumsToN(num + 1);
    }
}

NaturanNumsToN(n);