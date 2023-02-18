// Программа принимает на вход число N 
// и выдает таблицу кубов чисел до N

Console.Clear();

int[] GetCubes(int num){

    int i = 1, j = 0;
    int length = num;

    if(num < 0){

        i = num;
        length = -num;
        length += 2;
        num = 1;
    }
    int[] resultArray = new int[length];

    for (; i <= num; i++){
        resultArray[j] = Convert.ToInt32(Math.Pow(i, 3));
        j++;
    }
    
    return resultArray;
}


Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());

int[] result = GetCubes(N);

for (int i = 0; i < result.Length; i++)
{

    Console.Write($"{result[i]} ");

}
