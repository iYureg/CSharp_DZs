// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using System;
using static System.Console;

Clear();

Write("Введите число: ");
int num = int.Parse(ReadLine());


WriteLine(ShowNums(num));
string ShowNums(int n){

    if(n == 1) return n.ToString();


    string result = n <= 0
            ? ShowNums(n + 1) + ", " + n.ToString()
            : n.ToString() + ", " + ShowNums(n - 1);

    return result;
}
