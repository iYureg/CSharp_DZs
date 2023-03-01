// пользователь вводит произвольное количество чисел
// программа считает сколько чисел больше нуля

// 0, 7, 8, -2, -2  -> 2

bool isPositive(int n){
    return n > 0;
}

int CountPositive(string[] nums){
    int counter = 0;
    
    for (int i = 0; i < nums.Length; i++)
    {
       counter += isPositive(int.Parse(nums[i])) ? 1 : 0;
    }
    return counter;
}

Console.Clear();
Console.Write("Введите числа через пробел: ");
string str = Console.ReadLine();

string[] array = str.Split(" ");

Console.WriteLine($"[ {String.Join(", ", array)} ]  вы ввели - {CountPositive(array)} - чисел больше нуля");
