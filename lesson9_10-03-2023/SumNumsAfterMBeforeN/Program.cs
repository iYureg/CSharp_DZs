// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using System;
using static System.Console;

Clear();
Write("Введите начало: ");
int start = int.Parse(ReadLine());
Write("Введите конец: ");
int finish = int.Parse(ReadLine());

WriteLine(ShowNumbers(start,finish));

int ShowNumbers(int s, int f)
{
    if (s == f)
    {
        return f;
    }

    int sum = f < s 
        ? ShowNumbers(s, f + 1) + f 
        : ShowNumbers(s, f - 1) + f;
    return sum;
}

