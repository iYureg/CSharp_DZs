// программа принимает на вход число и выдает сумму
// цифр в числе 

int GetFirst(int num){
    int first = 0;

    while (num > 0)
    {
        first = num;
        num /= 10;
    }

    return first;
}

int GetDegree(int num){
    int count = 0;

    while(num > 9){
        num /= 10;
        count++;
    }

    return count;
}

int GetPow(int num, int pow){
    int result = num;

    for (int i = 1; i < pow; i++)
    {
        result *= num;
    }

    return result;
}

int GetDigitSum(int num){
    int result = GetFirst(num);

    int newNum = num - (GetFirst(num) * (GetPow(10, GetDegree(num))));

    while(newNum > 9){
        result += GetFirst(newNum);

        newNum -= GetFirst(newNum) * (GetPow(10, GetDegree(newNum)));
    }

    return result += num % 10;;
}


Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int result = number;
if(number >= 10) result = GetDigitSum(number);
if(number < 0) result = GetDigitSum(number * (-1)) * (-1);

Console.WriteLine($"Сумма цифр числа {number} = {result}");