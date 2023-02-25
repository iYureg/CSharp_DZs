// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] GetRandomArray(int size){

    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }

    return array;
}

int GetOddSum(int[] arr){
    int result = 0;

    for (int i = 1; i < arr.Length; i += 2){
        result += arr[i];
    } 

    return result;
}

int[] array = GetRandomArray(11);

Console.Clear();
Console.WriteLine($"[ {String.Join(", ", array)} ]");
Console.WriteLine($"Сумма нечетных позиций = {GetOddSum(array)}");