// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

int[] GetRandomArray(int size){

    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }

    return array;
}

int CountEvenElems(int[] array)
{
    int counter = 0;

    foreach (var elem in array){
        // counter += elem % 2 == 0 ? 1 : 0;
        if(elem % 2 == 0) counter++;
    }
    return counter;
}

int[] randomArr = GetRandomArray(10);

Console.Clear();
Console.WriteLine($"[ {String.Join(", ", randomArr)} ]");
Console.WriteLine($"Количество четных чисел в массиве -> {CountEvenElems(randomArr)}");