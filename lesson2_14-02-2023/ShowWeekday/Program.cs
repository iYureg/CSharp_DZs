// Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

string[] weekdays ={
    "Воскресенье",
    "Понедельник",
    "Веторник",
    "Среда",
    "Четверг",
    "Пятница",
    "Суббота"
};

Console.WriteLine("Введите цифру обозначающую какой сегодня день недели: 1 - 7");
int day = int.Parse(Console.ReadLine());

if( day == 7 || day == 6 )
{
    if( day == 7 ) day = 0;
    Console.WriteLine($"Сегодня выходной - {weekdays[day]}");
}
else if ( day > 0 && day <= 5 )
{
    Console.WriteLine($"Сегодня рабочий день - {weekdays[day]}");
}
else
{
    Console.WriteLine($"Такого дня недели нет: {day}");
}




