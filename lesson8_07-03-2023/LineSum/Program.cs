// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка




int[,] array = GetArr(Prompt("Введите количесто рядов: "), Prompt("Введите количество столбцов: "));
PrintArray(array);
Console.WriteLine();
Console.Write($"{String.Join(" ", GetMinLine(array))} <- Ряд с минимальной суммой элементов");

int[] GetMinLine(int[,] arr){
    int line = arr.GetLength(1);
    int[] result = new int[line];

    int iMin = 0; 
    int minSum = 0;
    for (int i = 0; i < arr.GetLength(0); i++){

        int sum = 0;
        for (int j = 0; j < line; j++){
            sum += arr[i, j];
        }
        
        minSum = i != 0 ? minSum : sum;
        if(sum <= minSum) {
            minSum = sum;
            iMin = i;
        }
   
    }
    for (int k = 0; k < line; k++){
        result[k] = arr[iMin, k];
    }
    return result;
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
            result[i, j] = new Random().Next(1, 10);
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
