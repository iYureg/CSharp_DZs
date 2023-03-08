//  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int r = Prompt("Введите количество рядов: ");
int[,] array = GetArr(r, Prompt("Введите количество столбцов: "));
PrintArray(array);
double[] result = GetResults(CountColumns(array), r);
Console.WriteLine();
Console.WriteLine($"[ {String.Join(", ", result):f3} ] <- Среднее арифметическое столбцов");

double[] GetResults(int[] arr, int div){
    double[] result = new double[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        result[i] = Math.Round(Convert.ToDouble(arr[i]) / div, 2);
    }
    return result;
}

int[] CountColumns(int[,] arr){
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);

    int[] result = new int[columns];

    for (int i = 0; i < rows; i++){   

        for (int j = 0; j < columns; j++){
            
            result[j] += arr[i, j];
        }

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