//==================================================================================
/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2              7 4 2 1
// 5 9 2 3    ==>>>>    9 5 3 2
// 8 4 2 4              8 4 4 2
//==================================================================================*/

/*
int UserInput(string message)
{
    Console.Write(message + "... ");
    Int32.TryParse(Console.ReadLine(), out int num);
    return num;
}

int[,] Create2dIntArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void PrintArray(int[,] array, int minValue, int maxValue) // выравнивание пробелами - вычисление по длине макс или мин
{
    int fieldLength = Math.Max(Convert.ToString(minValue).Length, Convert.ToString(maxValue).Length);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            string filler = new string(' ', fieldLength - Convert.ToString(array[i, j]).Length);
            Console.Write(filler + array[i, j] + "  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SortRows (int[,] array, int method) 
// сортировка ВЫБОРОМ = поиск минимального/максимального 
// и перемещение его в конец
// поиск максимального - сортировка по возрастанию
// поиск минимального - сортировка по убыванию
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int counter = 0; counter < array.GetLength(1); counter++)
        {
            int lastIndex = array.GetLength(1) - 1 - counter;
            int minMaxIndex = 0;

            if (method == 0)  
                minMaxIndex = FindMinIndex(array, i, lastIndex);
            else
                minMaxIndex = FindMaxIndex(array, i, lastIndex);

            if (minMaxIndex != lastIndex)
            {
                int temp = array[i, minMaxIndex];
                array[i, minMaxIndex] = array[i, lastIndex];
                array[i, lastIndex] = temp;
            }
        }
    }
}

int FindMaxIndex (int[,] array, int row, int lastIndex)
{
    int maxIndex = 0;
    for (int j = 1; j <= lastIndex; j++)
        if(array[row, j] > array[row, maxIndex]) maxIndex = j;
    return maxIndex;
}

int FindMinIndex (int[,] array, int row, int lastIndex)
{
    int minIndex = 0;
    for (int j = 1; j <= lastIndex; j++)
        if(array[row, j] < array[row, minIndex]) minIndex = j;
    return minIndex;
}

int rows    = UserInput("Введите размеры массива: количество строк");
int columns = UserInput("                         количество колонок");

int minValue = 0;  //UserInput("Массив генерируется в диапазоне от");
int maxValue = 99; //UserInput("                                до");

int[,] myArray = Create2dIntArray(rows, columns, minValue, maxValue);
PrintArray(myArray, minValue, maxValue);

int userMethod = UserInput("Сортировка по убыванию - введите 0, по возрастанию - введите другое");

SortRows(myArray, userMethod);
if (userMethod == 0)
    Console.WriteLine("\nСортировка каждой из строк по убыванию:");
else
    Console.WriteLine("\nСортировка каждой из строк по возрастанию:");
PrintArray(myArray);

*/

//==================================================================================
/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить СТРОКУ С НАИМЕНЬШЕЙ СУММОЙ элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
// наименьшей суммой элементов: 1 строка
//==================================================================================*/

/*
int UserInput(string message)
{
    Console.Write(message + "... ");
    Int32.TryParse(Console.ReadLine(), out int num);
    return num;
}

int[,] Create2dIntArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void PrintArray(int[,] array, int minValue, int maxValue)
{
    int fieldLength = Math.Max(Convert.ToString(minValue).Length, Convert.ToString(maxValue).Length);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            string filler = new string(' ', fieldLength - Convert.ToString(array[i, j]).Length);
            Console.Write(filler + array[i, j] + "  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int FindMinSumRow (int[,] array)
{
    int minSumRow = 0;
    for (int i = 1; i < array.GetLength(0); i++)
        if(CountRowSum(array, i) < CountRowSum(array, minSumRow)) minSumRow = i;
    return minSumRow;
}

int CountRowSum (int[,] arr, int row)
{
    int sum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
        sum += arr[row ,j];
    return sum;
}

int rows    = UserInput("Введите размеры массива: количество строк");
int columns = UserInput("                         количество колонок");

int minValue = UserInput("Массив генерируется в диапазоне от");
int maxValue = UserInput("                                до");

int[,] myArray = Create2dIntArray(rows, columns, minValue, maxValue);
PrintArray(myArray);

// проверка
// for(int i = 0; i < myArray.GetLength(0); i++)
//     System.Console.WriteLine(CountRowSum(myArray, i));

Console.WriteLine($"Наименьшая сумма элементов в {FindMinSumRow(myArray) + 1}й строке ({CountRowSum(myArray, FindMinSumRow(myArray))}).");
*/

//==================================================================================
/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4       3 4
// 3 2       3 3
// Результирующая матрица будет:
// 18 20
// 15 18
//==================================================================================*/

/*
int UserInput(string message)
{
    Console.Write(message + "... ");
    Int32.TryParse(Console.ReadLine(), out int num);
    return num;
}

int[,] CreateRndMatrix(int mtrxNumber, int rows, int columns)
{
    int minValue = 1;
    int maxValue = 9;

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
            // расчитано на (+)двухзначные
            string filler = new string(' ', 3 - Convert.ToString(array[i, j]).Length);
            Console.Write(filler + array[i, j] + "  ");
        }
        Console.WriteLine();
    }
}

bool ValidateMatrices (int columns1st, int rows2nd)
{
    return columns1st == rows2nd;
}

int[,] МultipleMatrix (int[,] matrix1, int[,] matrix2)
{
    System.Console.WriteLine("Умножаем ... ");
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int resultRow = 0; resultRow < resultMatrix.GetLength(0); resultRow++)
    {
        for (int resultCol = 0; resultCol < resultMatrix.GetLength(1); resultCol++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                resultMatrix[resultRow, resultCol] += matrix1[resultRow, j] * matrix2[j, resultCol];
                
                string sign = " + ";
                if (j == matrix1.GetLength(1) - 1) sign = "";
                Console.Write($"{matrix1[resultRow, j]}·{matrix2[j, resultCol]}{sign}");
            }
            if (resultCol < resultMatrix.GetLength(1) - 1) Console.Write($"  |  ");
        }
        Console.WriteLine();
    }

    return resultMatrix;
}

Console.WriteLine("======== УМНОЖЕНИЕ МАТРИЦ ========");
Console.WriteLine("Умножение возможно, если кол-во колонок 1й матрицы равно кол-ву строк 2й.");
int rows1st    = UserInput("Введите размеры 1й матрицы: кол-во строк");
int columns1st = UserInput("                            кол-во колонок");

int rows2nd    = UserInput("Введите размеры 2й матрицы: кол-во строк");
int columns2nd = UserInput("                            кол-во колонок");

if (ValidateMatrices(columns1st, rows2nd))
{
    int[,] matrix1st = CreateRndMatrix(1, rows1st, columns1st);
    int[,] matrix2nd = CreateRndMatrix(2, rows2nd, columns2nd);
    System.Console.WriteLine("Первая матрица:");
    PrintArray(matrix1st);
    System.Console.WriteLine("Вторая матрица:");
    PrintArray(matrix2nd);

    int[,] resultMatrix = МultipleMatrix (matrix1st, matrix2nd);
    Console.WriteLine("Результат умножения первой матрицы на вторую:");
    PrintArray(resultMatrix);
}
else
{
    System.Console.WriteLine("Матрицы таких габаритов умножить невозможно.");
}

*/

//==================================================================================
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите 
// программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
//==================================================================================

/*
int UserInput(string message)
{
    Console.Write(message + "... ");
    Int32.TryParse(Console.ReadLine(), out int num);
    return num;
}

bool Validate3dArray(int z, int i, int j)
{
    if (z * i * j < 90) return true;
    return false;
}

bool IsNumberUnique(int num, int[,,] array) 
{
    for(int z = 0; z < array.GetLength(0); z++)
        for(int i = 0; i < array.GetLength(1); i++)
            for(int j = 0; j < array.GetLength(2); j++)
                if (num == array[z, i, j]) return false;
    return true;
}

int GenerateNum(int[,,] array3d)
{
    while(true)
    {
        int num = new Random().Next(10, 100);
        if (IsNumberUnique(num, array3d)) return num;
    }
}

int[,,] Create3dArrayOfUniques(int layers, int rows, int columns)
{
    int[,,] array3d = new int[layers, rows, columns];

    for(int z = 0; z < layers; z++)
        for(int i = 0; i < rows; i++)
            for(int j = 0; j < columns; j++)
                array3d[z, i, j] = GenerateNum(array3d);

    return array3d;
}

void Print3dArrayAtRow(int[,,] array)
{
    for(int i = 0; i < array.GetLength(1); i++)
    {    
        for(int z = 0; z < array.GetLength(0); z++)
        {
            for(int j = 0; j < array.GetLength(2); j++)
            {
                Console.Write(array[z, i, j] + " ");
            }
            Console.Write("      ");
        }
        Console.WriteLine();
    }
}

void Print3dArrayAsLine(int[,,] array)
{
    System.Console.Write($"\nЧисла из массива (для проверки уникальности - всего {array.Length}):\n");
    for(int z = 0; z < array.GetLength(0); z++)
        for(int i = 0; i < array.GetLength(1); i++) 
            for(int j = 0; j < array.GetLength(2); j++)
                Console.Write(array[z, i, j] + ", ");
}

Console.WriteLine("====== ТРЁХМЕРНЫЙ МАССИВ ИЗ УНИКАЛЬНЫХ ДВУЗНАЧНЫХ ЧИСЕЛ ======");
int layers  = UserInput("Введите габариты 3D массива: слои");
int rows    = UserInput("                             строки");
int columns = UserInput("                             колонки");

if (Validate3dArray(layers, rows, columns))
{
    int[,,] myArray = Create3dArrayOfUniques(layers, rows, columns);
    Print3dArrayAtRow(myArray);
    Print3dArrayAsLine(myArray);
}
else
    System.Console.WriteLine("Такой массив невозможно заполнить только уникальными значениями.");

*/

//==================================================================================
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
//==================================================================================

int UserInput(string message)
{
    Console.Write(message + "... ");
    Int32.TryParse(Console.ReadLine(), out int num);
    return num;
}

void PrintArray(string[,] array, int format)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(new string(' ', format - array[i, j].Length) + array[i, j] + "  ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FillArrayBySpiral(string[,] array, int counter)
{
    int maxCounter = counter + array.Length - 1;
    int firstColumn = 0;
    int lastColumn = array.GetLength(1) - 1;
    int firstRow = 0;
    int lastRow = array.GetLength(0) - 1;

    for (int steps = 1; steps <= array.GetLength(1) / 2 + (array.GetLength(1) % 2); steps ++)
    {   
       for (int i = firstRow, j = firstColumn; j < lastColumn; j++)
            if (counter <= maxCounter) 
                array[i, j] = ($"{counter++} ►");

        for (int i = firstRow, j = lastColumn; i < lastRow; i++)
            if (counter <= maxCounter) 
                array[i, j] = ($"{counter++} ▼");

        for (int i = lastRow, j = lastColumn; j > firstColumn; j--)
            if (counter <= maxCounter) 
                array[i, j] = ($"{counter++} ◄");

        for (int i = lastRow, j = firstColumn; i > firstRow; i--)
            if (counter <= maxCounter) 
                array[i, j] = ($"{counter++} ▲");
        
        firstRow += 1;
        firstColumn += 1;
        
        if (counter < maxCounter && lastRow - firstRow >= 0) lastRow -= 1;
        if (counter < maxCounter && lastColumn - firstColumn >= 0) lastColumn -= 1;
    }
}

Console.WriteLine("====== ЗАПОЛНЕНИЕ МАССИВА ПО СПИРАЛИ ======");
int rows    = UserInput("Обозначьте габариты массива: строки");
int columns = UserInput("                             колонки");
int counter = UserInput("С какого числа начинаем заполнять?");

string [,] myArray = new string[rows, columns];
int format = Convert.ToString(counter + myArray.Length - 1).Length + 2;

FillArrayBySpiral(myArray, counter);
PrintArray(myArray, format);