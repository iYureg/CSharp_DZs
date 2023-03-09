// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

int[,] mtx1 = GetMatrix(Prompt("Введите количесто рядов первой матрицы: "), 
                        Prompt("Введите количество столбцов первой матрицы: "));
int[,] mtx2 = GetMatrix(Prompt("Введите количесто рядов второй матрицы: "), 
                        Prompt("Введите количество столбцов второй матрицы: "));

PrintArray(mtx1);
Console.WriteLine();
PrintArray(mtx2);


if(!Validate(mtx1,mtx2)){
    Console.WriteLine("----------------");
    Console.Write("Количество столбцов первой марицы не совпадает с количеством рядов второй");
}else{
    int[,] resultMtx = GetMtxResult(mtx1, mtx2);
    Console.WriteLine("++++++++++++++++");
    PrintArray(resultMtx);
}


int[,] GetMtxResult(int[,] m1, int[,] m2){
    int rows = m1.GetLength(0);
    int cols = m2.GetLength(1);

    int[,] result = new int[rows, cols];

    for (int i = 0; i < rows; i++){
        for (int j = 0; j < cols; j++){

            result[i, j] = 0;
            for (int k = 0; k < m1.GetLength(1); k++){
                result[i, j] += m1[i, k] * m2[k, j];
            }
        }
    }
    return result;
}

bool Validate(int[,] m1, int[,] m2){
    return m1.GetLength(1) == m2.GetLength(0);
}


int Prompt(string msg){
    System.Console.Write(msg);
    string number = Console.ReadLine();
    int num = Convert.ToInt32(number);
    return num;
}


int[,] GetMatrix(int r, int c){
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
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}
