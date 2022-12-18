// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] GetRandom2DArray(int sizeCol = 10, int sizeRow = 10, int minVal = 0, int maxVal = 100)
{
    int[,] result = new int[sizeCol, sizeRow];

    for (int i = 0; i < sizeCol; i++)
    {
        for (int j = 0; j < sizeRow; j++)
        {
            result[i, j] = new Random().Next(minVal, maxVal + 1);
        }
    }
    return result;
}

void Print2DArray(int[,] array)
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

void Print1DArray(double[] array)
{
    Console.WriteLine("{0}", string.Join("\t", array));
}

double[] CalcColsAVG(int[,] array)
{
    double[] result = new double[array.GetLength(1)];

    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            result[i] += (double)array[j, i];
        }
        result[i] = Math.Round(result[i] / (double)array.GetLength(0), 2); // делим сумму элементов столбца на количество элементов
    }

    return result;
}

var test2DArray = GetRandom2DArray(new Random().Next(1, 11), new Random().Next(1, 11)); // генерируем случайный массив с размером [1..10, 1..10]
Print2DArray(test2DArray);
Console.WriteLine("Среднее арифметическое столбцов:");
Print1DArray(CalcColsAVG(test2DArray));