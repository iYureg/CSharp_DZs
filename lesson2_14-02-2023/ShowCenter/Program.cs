// программа принимает на вход трехзначное число
// и показывает вторую цифру этого числа



int num = new Random().Next(100, 1000);

int left = num / 100;
int center = (num - (left * 100)) / 10;

Console.WriteLine($"{num} ->  {center}");

