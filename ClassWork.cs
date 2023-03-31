/* Задайте массив из 12 элементов, заполненный случайными числами из 
// промежутка [-9, 9]. Найдите сумму отрицательных элементов массива. */

/*
int UserInput(string message)
{
    System.Console.Write(message + "... ");
    int num = Convert.ToInt32(Console.ReadLine());

    return num;
}

int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0;  i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    
    return array;
}

void WriteArray(int[] array)
{
    for(int i = 0 ; i < array.Length - 1; i++)
        Console.Write(array[i] + ", ");
    
    Console.WriteLine(array[array.Length -1]);
}

int SumOfNegatives (int[] array)
{
    int sum = 0;

    for (int i=0; i < array.Length; i++)
        {
            if (array[i] < 0) sum += array[i];
        }

    return sum;
}

int arrSize     = 12;
int arrBorderMin = -9;
int arrBorderMax = 9;

int[] myArray = CreateRandomArray(arrSize, arrBorderMin, arrBorderMax);
WriteArray(myArray);

int sumNeg = SumOfNegatives (myArray);
System.Console.WriteLine("Сумма отрицательных элементов = " + sumNeg);

*/

/* Напишите программу замена элементов массива: положительные элементы 
// замените на соответствующие отрицательные, и наоборот.*/

/*
int UserInput(string message)
{
    System.Console.Write(message + "... ");
    int num = Convert.ToInt32(Console.ReadLine());

    return num;
}

int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0;  i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    
    return array;
}

void WriteArray(int[] array)
{
    for(int i = 0 ; i < array.Length - 1; i++)
        Console.Write(array[i] + ", ");
    
    Console.WriteLine(array[array.Length - 1]);
}

int[] RevertMassive(int[] array)
{
    for (int i=0; i < array.Length; i++)
        array[i] = array[i] * (-1);
    
    return array;
}

int arrSize     = UserInput("Введите размер массива");
int arrBorderMin = UserInput("Введите минимальное значение массива");
int arrBorderMax = UserInput("Введите максимальное значение массива");

int[] myArray = CreateRandomArray(userSize, minUser, maxUser);
WriteArray(myArray);

myArray = RevertMassive(myArray);

System.Console.Write("Преобразованный массив: ");
WriteArray(myArray);

*/

/* Задайте массив. Напишите программу, которая определяет, присутствует 
// ли заданное число в массиве.*/

/*
int UserInput(string message)
{
    System.Console.Write(message + "... ");
    int num = Convert.ToInt32(Console.ReadLine());

    return num;
}

int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0;  i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    
    return array;
}

void WriteArray(int[] array)
{
    for(int i = 0 ; i < array.Length - 1; i++)
        Console.Write(array[i] + ", ");
    
    Console.WriteLine(array[array.Length -1]);
}

bool FindElem(int[] array, int num)
{
    for (int i=0; i < array.Length; i++)
        {
            if (array[i] == num)
                return true;
        }
            
    return false;
}

int arrSize     = UserInput("Введите размер массива");
int arrBorderMin = UserInput("Введите минимальное значение массива");
int arrBorderMax = UserInput("Введите максимальное значение массива");

int[] myArray = CreateRandomArray(userSize, minUser, maxUser);
WriteArray(myArray);

int userNum = UserInput("Введите число для поиска");

if (FindElem(myArray, userNum))
    Console.WriteLine("Заданное число присутствует в массиве");
else
    Console.WriteLine("Заданное число отсутствует в массиве");

*/
/* Создать массив из m элементов. Посчитать количество элементов, 
// входящих в интервал [a, b]*/

/*
int UserInput(string message)
{
    System.Console.Write(message + "... ");
    int num = Convert.ToInt32(Console.ReadLine());

    return num;
}

int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0;  i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    
    return array;
}

void WriteArray(int[] array)
{
    for(int i = 0 ; i < array.Length - 1; i++)
        Console.Write(array[i] + ", ");
    
    Console.WriteLine(array[array.Length -1]);
}

int CountInterval(int[] array, int min, int max)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
            if (array[i] >= min && array[i] <= max) 
		count ++;

    return count;            
}

int arrSize     = UserInput("Введите размер массива");
int arrBorderMin = UserInput("Введите минимальное значение массива");
int arrBorderMax = UserInput("Введите максимальное значение массива");

int[] myArray = CreateRandomArray(arrSize, arrBorderMin, arrBorderMax);
WriteArray(myArray);

int intervMin = UserInput("Введите начало интервала поиска");
int intervMax = UserInput("Введите конец интервала поиска");

int countInterv = CountInterval(myArray, intervMin, intervMax);
System.Console.WriteLine("Количество элементов из заданного интервала: " + countInterv);

*/
//Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний 
//элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

/*
int UserInput(string message)
{
    System.Console.Write(message + "... ");
    int num = Convert.ToInt32(Console.ReadLine());

    return num;
}

int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0;  i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    
    return array;
}

void WriteArray(int[] array)
{
    for(int i = 0 ; i < array.Length - 1; i++)
        Console.Write(array[i] + ", ");
    
    Console.WriteLine(array[array.Length - 1]);
}

int[] CreateArrMultiplePairs(int[] array)
{
    int size = array.Length / 2 + array.Length % 2;
    int[] resultArray = new int[size];

    for (int i=0; i < size; i++)
            resultArray[i] = array[i] * array[array.Length - 1 - i];

    return resultArray;            
}

int arrSize     = UserInput("Введите размер массива");
int arrBorderMin = UserInput("Введите минимальное значение массива");
int arrBorderMax = UserInput("Введите максимальное значение массива");

int[] myArray = CreateRandomArray(arrSize, arrBorderMin, arrBorderMax);
System.Console.Write("Сгенерированный массив: ");
WriteArray(myArray);

int[] newArray = CreateArrMultiplePairs(myArray);
System.Console.Write("Массив результатов умножения: ");
WriteArray(newArray);
*/

//Напишите программу, которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник с сторонами такой длины.

/*
int UserInput (string message)
{
    System.Console.Write(message + "... ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

bool IsTriangleExist (int ab, int bc, int ac)
{
    return !(ab > bc + ac || bc > ab + ac || ac > ab + bc);
}

System.Console.WriteLine("===== СУЩЕСТВУЕТ ЛИ ТРЕУГОЛЬНИК ? =====");
System.Console.WriteLine("Введите длины сторон треугольника...");
int sideAB = UserInput("1я сторона");
int sideBC = UserInput("2я сторона");
int sideAC = UserInput("3я сторона");

System.Console.Write("Треугольник с такими сторонами ");

if (IsTriangleExist(sideAB, sideBC, sideAC)) 
    System.Console.WriteLine("существует.");
else
    System.Console.WriteLine("не существует.");

*/
//Не используя рекурсию, выведите первые N чисел Фибоначчи. 
//Первые два числа Фибоначчи: 0 и 1.

/*
int UserInput (string message)
{
    System.Console.Write(message + "... ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void PrintFibonachiRow(int frstElem, int scndElem, int rowLngth)
{
    // простая печать ряда без массива
    System.Console.WriteLine($"{frstElem}  {scndElem}  ");
    for(int i=3; i <= rowLngth; i++)
    {
        int thrdElem = scndElem + frstElem;
        frstElem = scndElem;
        scndElem = thrdElem;
        Console.Write(thrdElem + "  ");
    }
    Console.WriteLine();
}

int[] CreateFibonachiRow(int element1, int element2, int rowLngth) 
{
    //создание фибоначчи в массиве
    int[] fibonachi = new int[rowLngth];
    fibonachi[0] = element1;
    fibonachi[1] = element2;
    for(int i=2; i < rowLngth; i++)
        fibonachi[i] = fibonachi[i-1] + fibonachi[i-2];

    return fibonachi;
}

void PrintArrFibonachi (int[] fib)
{
    //печать массива
    for (int i = 0; i < fib.Length; i++)
        System.Console.Write(fib[i] + "  ");

    System.Console.WriteLine();
}

Console.WriteLine("===== РЯД ФИБОНАЧЧИ =====");
int firstElem = UserInput("Введите 1й элемент ряда");
int secondElem = UserInput("Введите 2й элемент ряда");
int rowLength = UserInput("Введите длину ряда");

Console.WriteLine($"Ваш ряд Фибоначчи:");
//PrintFibonachiRow(firstElem, secondElem, rowLength);
int[] myFib = CreateFibonachiRow(firstElem, secondElem, rowLength);
PrintArrFibonachi(myFib);

*/

/*Напишите программу, которая будет создавать копию заданного 
//массива с помощью поэлементного копирования.*/

/*
int UserInput(string message)
{
    System.Console.Write(message + "... ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[] CreateRandomArray(int min, int max, int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(min, max + 1);
    return arr;
}

int[] CopyArray(int[] arr)
{
    int[] newArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
        newArr[i] = arr[i];
    return newArr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write(arr[i] + "  ");
    Console.WriteLine();
}
System.Console.WriteLine("======= КОПИРОВАНИЕ МАССИВА (ССЫЛОЧНЫЙ ТИП ДАННЫХ) =======");
int minValue = UserInput("Введите минимум диапазона");
int maxValue = UserInput("Введите максимум диапазона");
int userSize = UserInput("Введите размер создаваемого массива");

int[] myArray = CreateRandomArray(minValue, maxValue, userSize);
System.Console.WriteLine("Сгенерированный массив:");
PrintArray(myArray);

int[] copiedArray = CopyArray(myArray);
System.Console.WriteLine("Скопированный массив:");
PrintArray(copiedArray);

System.Console.WriteLine("\nИзменим элемент ПЕРВОГО массива Array[2] = 100500...");
myArray[2] = 100500;
System.Console.Write("Измененный первый массив: ");
PrintArray(myArray);
System.Console.Write("Второй (скопированный) массив: ");
PrintArray(copiedArray);

System.Console.WriteLine("\nИзменим элемент ВТОРОГО массива newArray[1] = 978...");
copiedArray[1] = 978;
System.Console.Write("Первый (измененный начальный) массив: ");
PrintArray(myArray);
System.Console.Write("Второй (скопированный) массив: ");
PrintArray(copiedArray);
*/

// ==========================================================
//СОЗДАНИЕ ДВУХМЕРНОГО МАССИВА
/*
int UserInput (string message)
{
    System.Console.Write(message + "... ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int [,] CreateRandom2dArray()
{
    int rows = UserInput("Введите количество рядов");
    int columns = UserInput("Введите количество колонок");
    int minValue = UserInput("Минимальное значение");
    int maxValue = UserInput("Максимальное значение");

    int [,] array = new int [,];
    
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue);

}

void Write2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0) ; i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] myArray = CreateRandom2dArray();
Write2dArray(myArray);
*/

// Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: A(ij) = i+j.

/*
int UserInput (string message)
{
    System.Console.Write(message + "... ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int [,] Create2dArray()
{
    int rows = UserInput("Введите количество рядов");
    int columns = UserInput("Введите количество колонок");

    int [,] array = new int [rows, columns];
    
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = i + j;

    return array;
}

void Write2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0) ; i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
}

int [,] myArray = Create2dArray();
Write2dArray(myArray);
*/

// Задайте двумерный массив. Найдите элементы, у которых 
// оба индекса чётные, и замените эти элементы на их квадраты.
/*
int UserInput (string message)
{
    System.Console.Write(message + "... ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int [,] Create2dArray()
{
    int rows = UserInput("Введите количество рядов");
    int columns = UserInput("Введите количество колонок");
    int minValue = UserInput("Минимальное значение");
    int maxValue = UserInput("Максимальное значение");

    int [,] array = new int [rows, columns];
    
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = i + j;

    return array;
}

void Write2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0) ; i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
}

void RedactArray (int [,] array)
{
    for(int i = 0; i < array.GetLength(0) ; i +=2)
        for(int j = 0; j < array.GetLength(1); j +=2)
            array[i,j] = array[i,j] * array[i,j];
}

int [,] myArray = Create2dArray();
Write2dArray(myArray);

RedactArray(myArray);
Write2dArray(myArray);
*/

// Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.)
// главная диагональ = элементы с индексами в колонка = строка

/*
int UserInput(string message)
{
    System.Console.Write(message + "... ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[,] Create2dArray()
{
    int rows = UserInput("Введите количество рядов и колонок (квадрат)");
    int minValue = UserInput("Минимальное значение");
    int maxValue = UserInput("Максимальное значение");

    int[,] array = new int[rows, rows];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < rows; j++)
            array[i, j] = i + j;

    return array;
}

void Write2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int SumMainDiagonal(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        sum = sum + array[i,i];
    
    return sum;
}

int[,] myArray = Create2dArray();
Write2dArray(myArray);

System.Console.WriteLine("Сумма элементов на главной диагонали равна " + SumMainDiagonal(myArray));

*/

// Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.
/*
int UserInput(string message)
{
    System.Console.Write(message + "... ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[,] Create2dArray()
{
    int rows = UserInput("Введите количество рядов и колонок (квадрат)");
    int minValue = UserInput("Минимальное значение");
    int maxValue = UserInput("Максимальное значение");

    int[,] array = new int[rows, rows];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < rows; j++)
            array[i, j] = i + j;

    return array;
}

void Write2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ChangeRows(int[,] array, int r1, int r2)
{
    if (r1 >= 0 && r1 < array.GetLength(0) &&
       r1 >= 0 && r1 < array.GetLength(0) &&
       r1 != r2)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[r1, j];
            array[r1, j] = array[r2, j];
            array[r2, j] = temp;
        }
    }
}

int[,] myArray = Create2dArray();
Write2dArray(myArray);

int row1 = UserInput("Введите номер 1й строки для замены") - 1;
int row2 = UserInput("Введите номер 2й строки для замены") - 1;

ChangeRows(myArray, row1, row2)
Write2dArray(myArray);
*/

//Задайте двумерный массив. Напишите программу, 
//которая заменяет строки на столбцы.

/*
int UserInput(string message)
{
    System.Console.Write(message + "... ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[,] CreateSquareArray()
{
    int size = UserInput("Введите количество рядов и колонок (квадрат)");
    int minValue = UserInput("Минимальное значение");
    int maxValue = UserInput("Максимальное значение");

    int[,] array = new int[size, size];

    for (int i = 0; i < size; i++)
        for (int j = 0; j < size; j++)
            array[i, j] = new Random().Next(minValue, maxValue);

    return array;
}

void Write2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ChangeRowsCols(int[,] array)
{
    // 2 2 8 6 2 
    // 8 2 6 3 7
    // 4 6 7 3 4
    // 7 7 2 8 7
    // 4 6 3 2 2


    // * 8 4 7 4
    // 2 * 6 7 6
    // 8 6 * 2 3
    // 6 3 3 * 2
    // 2 7 4 7 *

    for (int i = 1; i < array.GetLength(0); i++) // СТРОКИ
    {
        for (int j = 0; j < i; j++) // СТОЛБЦЫ
        {
                int temp = array[i, j];
                array[i, j] = array[j, i];
                array[j, i] = temp;
        }
    }
}

int[,] myArray = CreateSquareArray();
Write2dArray(myArray);

ChangeRowsCols(myArray);
Write2dArray(myArray);

*/


//Из двумерного массива целых чисел удалить строку и столбец, 
//на пересечении которых расположен наименьший элемент.
// *** создать новый массив, который меньше и переписать 
// *** в него нужные элементы

int UserInput(string message)
{
    System.Console.Write(message + "... ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[,] Create2dArray()
{
    int rows = UserInput("Введите количество рядов");
    int columns = UserInput("Введите количество колонок");
    int minValue = UserInput("Минимальное значение");
    int maxValue = UserInput("Максимальное значение");

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue);

    return array;
}

void Write2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[] FindArrayMin(int[,] array)
{
    int[] minIndex = new int[2];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < array[minIndex[0], minIndex[1]])
            {
                minIndex[0] = i;
                minIndex[1] = j;
            }
        }
    }
    return minIndex;
}

int[,] CutArray(int[,] sourceArray, int[] minCoord)
{
    int[,] newArray = new int[sourceArray.GetLength(0) - 1, sourceArray.GetLength(1) - 1];

    for (int i = 0, k = 0; i < sourceArray.GetLength(0); i++)
    {
        if (i != minCoord[0])
        {
            for (int j = 0, m = 0; j < sourceArray.GetLength(1); j++)
            {
                if (j != minCoord[1])
                {
                    newArray[k, m] = sourceArray[i, j];
                    m++;
                }
            }
            
            k++;
        }
    }
    return newArray;
}

int[,] myArray = Create2dArray();
Write2dArray(myArray);

int[,] cuttedArray = CutArray(myArray, FindArrayMin(myArray));
Write2dArray(cuttedArray);
