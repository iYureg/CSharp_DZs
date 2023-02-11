int a = int.Parse(Console.ReadLine()),
    b = int.Parse(Console.ReadLine()),
    c = int.Parse(Console.ReadLine()),
    max = a;


if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine("Максимальное введенное число: " + max);