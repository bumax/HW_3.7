// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Write("Введите m: ");
var m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
var n = Convert.ToInt32(Console.ReadLine());


double[,] GetMatrix(int sizeCol = 10, int sizeRow = 10, int minVal = 0, int maxVal = 100, int precision = 2) // precision - количество знаков, после запятой
{
    double[,] result = new double[sizeCol, sizeRow];
    precision = (int)Math.Pow(10,precision); // расчитываем, на сколько разрядов смещать случайное число
    for (int i = 0; i < sizeCol; i++)
    {
        for (int j = 0; j < sizeRow; j++)
        {
            result[i, j] = new Random().Next(minVal * precision, maxVal * precision + 1) / (double)precision;
        }
    }
    return result;
}

void Print2DArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

Print2DArray(GetMatrix(m,n));