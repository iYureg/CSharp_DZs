// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int[] GetRandomArr(int length, int min, int max)
{
    int[] array = new int[length];

    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

Console.Clear();
Console.Write("Введите длину массива: ");
int size = int.Parse(Console.ReadLine());

Console.Write("Введите минимальный элемент: ");
int A = int.Parse(Console.ReadLine());

Console.Write("Введите максимальный элемент: ");
int B = int.Parse(Console.ReadLine());

int[] result = GetRandomArr(size, A, B);


Console.WriteLine($"[  {String.Join(", ", result)}  ]");
