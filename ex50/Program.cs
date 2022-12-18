// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write("Введите индекс колонки элемента: ");
var m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс строки элемента: ");
var n = Convert.ToInt32(Console.ReadLine());

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

bool CheckBounds(int[,] array, int col, int row)
{
    /* Мы ещё так не умеем :-(
    try
    {
        array[col, row] = array[col, row]; // какое-нибудь обращение к элементу массива, не будет ли исключения?
        return true;
    }
    catch (IndexOutOfRangeException e)
    {
        return false;
    }*/
    return array.GetLength(0) > col && array.GetLength(1) > row; // т.к. нумерация с нуля, то длина всегда должна быть больше индекса
}

var test2DArray = GetRandom2DArray(new Random().Next(1, 21), new Random().Next(1, 21)); // генерируем случайный массив с размером [1..20, 1..20]
Print2DArray(test2DArray);
Console.WriteLine(CheckBounds(test2DArray, m, n) ? $"Такой элемент присутствует! И это {test2DArray[m,n]}" : "Нет такого элемента!");