// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
Console.Clear();
int[,] array = GetArr(Prompt("Введите количесто рядов: "), Prompt("Введите количество столбцов: "));
PrintArray(array);
Console.WriteLine();
SortArray(array);
PrintArray(array);

void SortArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int max = j;
            for (int k = j + 1; k < arr.GetLength(1); k++)
            {

            Console.Write($" {arr[i, k]} ");
                if (arr[i, k] > arr[i, max]) max = k;
            }
            Console.WriteLine();

            int temp = arr[i, j];
            arr[i, j] = arr[i, max];
            arr[i, max] = temp;
        }
    }
}

int Prompt(string msg){
    System.Console.Write(msg);
    string number = Console.ReadLine();
    int num = Convert.ToInt32(number);
    return num;
}


int[,] GetArr(int r, int c){
    int[,] result = new int[r, c];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(10, 100);
        }
    }
    return result;
}

void PrintArray(int[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}");
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}