// // точка пересечения между двумя прямыми на плоскости
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double[] lineA = new double[2];
double[] lineB = new double[2];
double[] result = new double[2];

Console.Clear();
Console.Write("Введите первый параметр первой прямой -> ");
lineA[0] = double.Parse(Console.ReadLine());

Console.Write("Введите второй параметр первой прямой -> ");
lineA[1] = double.Parse(Console.ReadLine());

Console.Write("Введите первый параметр второй прямой -> ");
lineB[0] = double.Parse(Console.ReadLine());

Console.Write("Введите второй параметр второй прямой -> ");
lineB[1] = double.Parse(Console.ReadLine());


bool CheckLines(double[] lineA, double[] lineB){

    if (lineA[0] == lineB[0])
    {
        if (lineA[1] == lineB[1])
        {
            return false;
        }
        else
        {
            return false;
        }
    }
    return true;
}

double[] CalcResult(double[] lineA, double[] lineB){
    double[] result = new double[2];

    result[0] = (lineA[1] - lineB[1]) / (lineB[0] - lineA[0]);
    result[1] = lineA[0] * result[0] + lineA[1];

    return result;
}

if(CheckLines(lineA,lineB)){
    result = CalcResult(lineA, lineB);
    Console.WriteLine($"Точка пересечения прямых -> [ {String.Join(", ", result)} ]");
}else{
    Console.WriteLine("Прямые не пересекаются");
}