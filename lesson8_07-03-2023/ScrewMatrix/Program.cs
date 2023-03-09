// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();
string[,] array = GetArray(
    Prompt("Введите количесто рядов: "), 
    Prompt("Введите количество столбцов: ")
);


if(!Validate(array)) Console.Write("Стороны не равны :(");
else{
    FillArray(array);
    PrintArray(array);
}


void FillArray(string[,] arr){
    int row = 0,
        col = 0,
        x = 1,
        y = 0,
        count = 0,
        r = arr.GetLength(0),
        c = arr.GetLength(1),
        stop = arr.GetLength(1);

    for (int i = 0; i < arr.Length; i++){
        arr[row, col] = Convert.ToString(i + 1);
        if (--stop == 0){
            stop = r * (count % 2) + c * ((count + 1) % 2) - (count / 2 - 1) - 2;
            int now = x;
            x = -y;
            y = now;
            count++;
        }
        col += x;
        row += y;
    }

}
 
bool Validate(string[,] arr){
    return arr.GetLength(1) == arr.GetLength(0);
}

int Prompt(string msg){
    System.Console.Write(msg);
    string number = Console.ReadLine();
    int num = Convert.ToInt32(number);
    return num;
}


string[,] GetArray(int r, int c){
    string[,] result = new string[r, c];
    for (int i = 0; i < result.GetLength(0); i++){
        for (int j = 0; j < result.GetLength(1); j++){
            result[i, j] = String.Empty;
        }
    }
    return result;
}

void PrintArray(string[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++){   
            if(int.Parse(arr[i,j]) < 10) Console.Write($"0{arr[i, j]} ");
            else Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

