// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1 7 -> такого числа в массиве нет


int row = Prompt("В каком ряду искать? ");
int column = Prompt("В каком столбце искать? ");

int[,] array = GetArr();
PrintArray(array);
if(!CheckElem(array, row, column)){
    Console.WriteLine($"Такой позиции нет :(");
}else{
    Console.WriteLine($"Найдено число -> {array[row - 1, column - 1]}");
}

int[,] GetArr(){
    int[,] result = new int[5, 5];
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

bool CheckElem(int[,] arr, int r, int c){
    return  arr.GetLength(0) >= r && arr.GetLength(1) >= c ? true : false;
}

int Prompt(string msg){
    System.Console.Write(msg);
    string number = Console.ReadLine();
    int num = Convert.ToInt32(number);
    return num;
}

