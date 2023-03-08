// задать массив размером m на n 
// заполнить случайными вещественными числами

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

double[,] GetArr(int rows, int cols){
    double[,] result = new double[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            result[i, j] = new Random().Next(0, 10) + new Random().NextDouble();
        }
    }
    return result;
}
void PrintArray(double[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]:f3}");
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}

int Prompt(string msg){
    System.Console.Write(msg);
    string number = Console.ReadLine();
    int num = Convert.ToInt32(number);
    return num;
}

// int r = Prompt("Введите количество рядов -> ");
// int c = Prompt("Введите количество столбцов -> ");
double[,] resultArr = GetArr(Prompt("Введите количество рядов -> "),Prompt("Введите количество столбцов -> "));
PrintArray(resultArr);



