/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
//в натуральную степень B. 3, 5 -> 243 (3⁵) */

/*
int UserInput(string message)
{
    System.Console.Write(message + "... ");
    int num = Convert.ToInt32(Console.ReadLine());

    return num;
}

int GetExponentiation (int number, int exponent)
{
    int result = 1;
    for(int i = 1; i <= exponent; i++)
        result = result * number;

    return result;
}

int userNum = UserInput("Введите целое число");
int userExponent = UserInput("Введите степень для этого числа");

System.Console.WriteLine($"Результат возведения {userNum} в степень {userExponent} = {GetExponentiation(userNum, userExponent)}.");
System.Console.WriteLine($"Проверка: Math.Pow({userNum}, {userExponent}) = {Math.Pow(userNum, userExponent)}.");
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*
int UserInput(string message)
{
    System.Console.Write(message + "... ");
    int num = Convert.ToInt32(Console.ReadLine());

    return num;
}

int SumDigits(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}

int userNum = UserInput("Введите целое число");

System.Console.WriteLine("Сумма цифр в этом числе = " + SumDigits(userNum));
*/

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

/*
int UserInput(string message)
{
    System.Console.Write(message + "... ");
    int num = Convert.ToInt32(Console.ReadLine());

    return num;
}

int[] FillUserArray(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = UserInput($"Введите {i}-й элемент массива");

    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
        Console.Write(arr[i] + ", ");
    Console.Write(arr[arr.Length-1] + "]");
}

int[] myArray = FillUserArray(UserInput("Введите длину желаемого массива"));
System.Console.WriteLine("Заполненный Вами массив выглядит так: ");
PrintArray(myArray);
*/

/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве. */

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

int CountEvenNumbers(int[] arr)
{
    int counter = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) counter += 1;
    }
    return counter;
}

int arrSize     = UserInput("Введите размер массива трёхзначных чисел");
int arrBorderMin = 100;
int arrBorderMax = 1000;

int[] myArray = CreateRandomArray(arrSize, arrBorderMin, arrBorderMax);
WriteArray(myArray);

Console.WriteLine("Количество чётных чисел в массиве =" + CountEvenNumbers(myArray));
*/

/*Задача 36: Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях. */

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

int OddIndexCounter(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum = sum + arr[i];
    }
    return sum;
}

int arrSize      = UserInput("Введите размер массива");
int arrBorderMin = UserInput("Введите минимальную границу для генерации");
int arrBorderMax = UserInput("Ведите максимальную границу для генерации");

int[] myArray = CreateRandomArray(arrSize, arrBorderMin, arrBorderMax);
WriteArray(myArray);

Console.WriteLine("Сумма элементов на нечётных позициях = " + OddIndexCounter(myArray));
*/

/*Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.*/

/*при использовании типа DOUBLE в данном алгоритме возникают проблемы
//с округлением числа: иногда элементы массива выводятся с кучей знаков
//после запятой типа 3,25000000001 или 4,2599999999998.
//данная проблема описана в документации к DOT NET 7.
//перевод всех методов и переменных с массивами в тип DECIMAL по возможности 
//максимально решает проблему с округлением, хотя этот тип занимает много памяти.
//Convert.ToDouble(new Random().Next(0, 101)) / 100 проблему не решает.
//ДРУГИМ МЕТОДОМ решения является введение многократного округления DOUBLE-ов:
//на уровне генерации элементов массива и на уровне вычисления разницы*/

/*
double[] CreateRandomDoubleArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];

    for(int i = 0;  i < size; i++)
        array[i] = Math.Round(new Random().Next(minValue, maxValue) + Math.Round(new Random().NextDouble(), 2), 2);
    
    return array;
}

void WriteArray(double[] array)
{
    for(int i = 0 ; i < array.Length; i++)
        Console.Write($"{array[i]}   ");
    
    Console.WriteLine();
}

double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
        if (array[i] < min) min = array[i];

    return min;
}

double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
        if (array[i] > max) max = array[i];
        
    return max;
}

int arrSize      =  10;
int arrBorderMin = -20;
int arrBorderMax =  20; 

double[] myArray = CreateRandomDoubleArray(arrSize, arrBorderMin, arrBorderMax);
System.Console.WriteLine($"Массив из элементов {arrSize} в интервале от {arrBorderMin} до {arrBorderMax}:");
WriteArray(myArray);

double min = FindMin(myArray);
double max = FindMax(myArray);
double minMaxDifference = Math.Round(max - min, 2);
System.Console.WriteLine($"Разница между min = {min} и max = {max} составляет {minMaxDifference}; ");
*/