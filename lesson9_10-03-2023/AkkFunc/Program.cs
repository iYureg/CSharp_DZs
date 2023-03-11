//  Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using System;
using static System.Console;


Clear();
WriteLine("Последовательность Аккермана");
Write("Введите число от 0 до 3: ");
int A = int.Parse(ReadLine());
Write("Введите число от 0 до 10: ");
int B = int.Parse(ReadLine());



if(!Validate(A,B)){
    WriteLine("Stack overflow :=(");
}else{

    WriteLine($"{RecAkkFn(A, B)} <- вызовов");
}


bool Validate(int num1, int num2)
{
    return ((num1 >= 0) && (num1 <= 3)) && ((num2 >= 0) && (num2 <= 10));
}



int RecAkkFn(int a, int b)
{
    if (a == 0) return b + 1;
    

    int result = ( a != 0 ) && ( b == 0 )
        ? RecAkkFn(a - 1, 1)
        : RecAkkFn(a - 1, RecAkkFn(a, b - 1));

    return result;
}
