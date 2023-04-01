/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
// вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9*/

/*
int UserInput(string message)
{
    Console.Write(message + "... ");
    Int32.TryParse(Console.ReadLine(), out int num);
    return num;
}

double[,] CreateRndDoubleArray()
{
    int rows = UserInput("Введите размеры массива: количество строк");
    int columns = UserInput("                         количество колонок");

    int minValue = UserInput("Массив генерируется в диапазоне от");
    int maxValue = UserInput("                                до");

    double[,] array = new double[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = Math.Round(new Random().Next(minValue, maxValue) + Math.Round(new Random().NextDouble(), 1), 1);

    return array;
}

void PrintDoubleArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            // выравниваем столбики пробелами перед числом в зависимости от длины числа
            // расчитано на отрицательные трёхзначные с 1 знаком после запятой
            string filler = new string(' ', 6 - Convert.ToString(array[i, j]).Length);
            Console.Write(filler + array[i, j] + "  ");
        }
        Console.WriteLine();
    }
}

double[,] myArray = CreateRndDoubleArray();
PrintDoubleArray(myArray);

*/

/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> числа с такими индексами в массиве нет*/

/*
int UserInput(string message)
{
    Console.Write(message + "... ");
    Int32.TryParse(Console.ReadLine(), out int num);
    return num;
}

int[,] CreateRndIntArray()
{
    int rows    = UserInput("Введите размеры массива: количество строк");
    int columns = UserInput("                         количество колонок");

    int minValue = -99;//UserInput("Массив генерируется в диапазоне от");
    int maxValue = 99; //UserInput("                                до");

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            // выравниваем столбики пробелами перед числом в зависимости от длины числа
            // расчитано на отрицательные двухзначные
            string filler = new string(' ', 3 - Convert.ToString(array[i, j]).Length);
            Console.Write(filler + array[i, j] + "  ");
        }
        Console.WriteLine();
    }
}

bool IsExist (int[,] array, int i, int j)
{
    return i > 0 && j > 0 && i < array.GetLength(0) && j < array.GetLength(1);
}


int[,] myArray = CreateRndIntArray();
PrintArray(myArray);

int i = UserInput("Введите позицию элемента: строка") - 1;
int j = UserInput("                          колонка") - 1; 

if (IsExist(myArray, i, j)) 
    System.Console.WriteLine($"Элемент массива в позиции ({i + 1}, {j + 1}) равен {myArray[i, j]}");
else
    System.Console.WriteLine("Указанная позиция в массиве отсутствует.");

*/

/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.   */

/*
int UserInput(string message)
{
    Console.Write(message + "... ");
    Int32.TryParse(Console.ReadLine(), out int num);
    return num;
}

int[,] CreateRndIntArray()
{
    int rows    = UserInput("Введите размеры массива: количество строк");
    int columns = UserInput("                         количество колонок");

    int minValue = -99;//UserInput("Массив генерируется в диапазоне от");
    int maxValue = 99; //UserInput("                                до");

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Print2dIntArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            // выравниваем столбики пробелами перед числом в зависимости от длины числа
            // расчитано на отрицательные двухзначные
            string filler = new string(' ', 3 - Convert.ToString(array[i, j]).Length);
            Console.Write(filler + array[i, j] + "  ");
        }
        Console.WriteLine();
    }
}

void Print1dDoubleArray (double[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
        Console.Write(array[i] + "; ");
    Console.Write(array[array.Length - 1]);
}

double[] CountColumnsAverage (int[,] sourceArray)
{
    double[] averArray = new double[sourceArray.GetLength(1)];

    for (int j = 0; j <sourceArray.GetLength(1); j++)
    {     
        for (int i = 0; i < sourceArray.GetLength(0); i++)
        {
            averArray[j] += sourceArray[i, j];
        }
        averArray[j] = Math.Round(averArray[j]/sourceArray.GetLength(0), 2);
    }
    return averArray;
}

int[,] myArray = CreateRndIntArray();
Print2dIntArray(myArray);

System.Console.WriteLine("Средние арифметические столбцов данного массива: ");
Print1dDoubleArray(CountColumnsAverage(myArray));
*/