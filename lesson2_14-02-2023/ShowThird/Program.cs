// // Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


int GetPow(long num)
{
    long first = 10;
    int count = 1;
    int ten = 10;

    while( first >= 10 )
    {
        first = num / Convert.ToInt64(Math.Pow(ten, count));

        count++;
    }

    return count - 1;
}


Console.WriteLine("Введите трехзначное число");
long number = long.Parse(Console.ReadLine());

Console.WriteLine(number);
if(number >= 100)
{
    int first = Convert.ToInt16(number / (Math.Pow(10, GetPow(number))));
    int num = Convert.ToInt16(number / (Math.Pow(10, GetPow(number) - 2)));
    int third = num % 10;
    Console.WriteLine($"Третья цифра числа {number} -> {third} ");
}
else
{
    Console.WriteLine($"Вы ввели не трехзначное число: {number}");
    
}







