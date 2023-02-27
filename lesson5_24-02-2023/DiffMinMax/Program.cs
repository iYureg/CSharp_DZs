// Задайте массив целых чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

// int[] GetRandomArray(int size){

//     int[] array = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(10, 100);
//     }

//     return array;
// }

int GetDiff(int[] arr){
    int min = arr[0];
    int max = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        min = min > arr[i] ? arr[i] : min;
        max = max < arr[i] ? arr[i] : max;
    }

    return max - min;
}

int[] StringToIntArray(string str)
{
    string[] stringArr = str.Split(",");
    int[] intArr = new int[stringArr.Length];

    for (int i = 0; i < stringArr.Length; i++){
        intArr[i] = int.Parse(stringArr[i]);
    }

    return intArr;
}

Console.Clear();
// int[] array = GetRandomArray(8);

Console.Write("Введите элементы массива через запятую: ");
string incomeString = Console.ReadLine();
int[] array = StringToIntArray(incomeString);

Console.WriteLine($"[ {String.Join(", ", array)} ]");
Console.WriteLine($"Разница между минимальным и максимальным -> {GetDiff(array)}");