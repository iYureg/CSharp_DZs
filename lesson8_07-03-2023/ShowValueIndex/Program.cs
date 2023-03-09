// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


Console.Clear();
int[,,] array =  GetArray(
                            Prompt("Ведите первый параметр трехмерного массива: "),
                            Prompt("Ведите второй параметр трехмерного массива: "), 
                            Prompt("Ведите третий параметр трехмерного массива: ")
                        );
PrintArray(array);



int Prompt(string msg){
    System.Console.Write(msg);
    string number = Console.ReadLine();
    int num = Convert.ToInt32(number);
    return num;
}


bool CheckNum(int[] arr, int num)
{

    for (int i = 0; i < arr.Length; i++)
    {
        return arr[i] == num;
        
    }
    return false;
}


int[,,] GetArray(int s1, int s2, int s3){
    int[,,] result = new int[s1,s2,s3];
    int[] values = new int[s1 + s2 + s3];
    for (int i = 0; i < s1; i++){
        for (int j = 0; j < s2; j++){
            for (int k = 0; k < s3; k++){

                int num = new Random().Next(10, 100);
                 
                if(CheckNum(values,num)){
                    k--;
                }else{
                    values[i + j + k] = num;
                    result[i, j, k] = num;
                }
            }
        }
    }
    return result;
}

void PrintArray(int[,,] arr){
    for (int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++){
            for (int k = 0; k < arr.GetLength(2); k++){
                
                Console.Write($"{arr[i, j, k]}({i},{j},{k}) ");
            }
        Console.WriteLine();
        }
    }
}
