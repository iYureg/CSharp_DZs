// написать цикл, который принимает на вход два числа (А и В)
// и возводит число А в натуральную степень В

double GetPower(int num, int pow){
    double result = num;

    for (int i = 1; i < pow; i++)
    {
        result *= num;
    }

    return result;
}

Console.Write("Введите число A: ");
int number = int.Parse(Console.ReadLine());

Console.Write("Введите степень числа A: ");
int power = int.Parse(Console.ReadLine());

Console.WriteLine($"{number} в {power} степени = {GetPower(number, power)}");

