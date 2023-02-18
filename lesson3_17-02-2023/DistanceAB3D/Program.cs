// найти расстояние между двумя точками в 3D пространстве


double GetDistance(int[] arr1, int[] arr2)
{
    double result = 0;

    for (int i = 0; i < 3; i++)
    {
        result += Math.Pow(arr1[i] - arr2[i], 2);
    }

    return Math.Sqrt(result);
}



Console.Clear();

int[] pointA = new int[3];
Console.Write("Введите x точки A ");
pointA[0] = int.Parse(Console.ReadLine());
Console.Write("Введите y точки A ");
pointA[1] = int.Parse(Console.ReadLine());
Console.Write("Введите z точки A ");
pointA[2] = int.Parse(Console.ReadLine());


int[] pointB = new int[3];
Console.Write("Введите x точки B ");
pointB[0] = int.Parse(Console.ReadLine());
Console.Write("Введите y точки B ");
pointB[1] = int.Parse(Console.ReadLine());
Console.Write("Введите z точки B ");
pointB[2] = int.Parse(Console.ReadLine());


Console.Write($"Дистанция между точками -> {GetDistance(pointA, pointB):f2}");
