// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool CheckFiveDigit(int num)

{
    bool flag = false;
    if(num <= 99999 && num >= 10000)
    {
        flag = true;
    }

        return flag;
    
}

bool CompareFirstLast(int num, int pow)
{

    int first = num / Convert.ToInt16(Math.Pow(10, pow));
    int last = num % 10;
    bool flag = false;
    if(first == last)
    {
        flag = true;
    }
    return flag;
}

bool CompareSecondPrelast(int num)
{
    int first = num / Convert.ToInt16(Math.Pow(10, 4));
    int threeDigit = (num - (first * 10000)) / 10;
    return CompareFirstLast(threeDigit, 2);
}

Console.Clear();
Console.Write("Введите пятизначное число: ");

int num = int.Parse(Console.ReadLine());
if(CheckFiveDigit(num)){
    if (CompareFirstLast(num, 4) && CompareSecondPrelast(num))
    {
        Console.WriteLine($"{num} - палиндром");
    }
    else
    {
        Console.WriteLine($"{num} - не палиндром");
    }
}
else
{
    Console.WriteLine($"Вы ввели не пятизначное число {num}");
}



Console.WriteLine($"{CompareSecondPrelast(num)}");


