/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

/*
int UserInput (string message)
{
    Console.Write(message + "... ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void PrintRowOfNumbers(int num)
{
    Console.Write(num + " ");
    if(num > 1) PrintRowOfNumbers(num - 1);
}

Console.WriteLine("====== ЧИСЛОВОЙ РЯД от N до 1 (рекурсия) ======");
int myNum = UserInput("Введите натуральное число >0");
Console.WriteLine($"Числовой ряд от {myNum} до 1:");
PrintRowOfNumbers(myNum);
*/

/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30  */

/*
int UserInput (string message)
{
    Console.Write(message + "... ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int CountSum (int num1, int num2)
{
    if (num1 < num2) return CountSum(num1 + 1, num2) + num1;
    if (num1 > num2) return CountSum(num1, num2 + 1) + num2;
    return num1;
}

Console.WriteLine("====== СУММА НАТУРАЛЬНЫХ ЧИСЕЛ между M и N ======");
int firstNum = UserInput("Введите 1-ое число");
int secondNum = UserInput("Введите 2-ое число");

Console.WriteLine($"Сумма чисел от {firstNum} до {secondNum} составляет: {CountSum(firstNum, secondNum)}");
*/

/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29   */

/*
int UserInput (string message)
{
    Console.Write(message + "... ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

double CountAkkerman(double m, double n)
{
    if (m > 0 && n == 0) return CountAkkerman(m - 1, 1);
    if (m > 0 && n > 0) return CountAkkerman(m - 1, CountAkkerman(m, n - 1));
    return n + 1;
}

Console.WriteLine("====== ВЫЧИСЛЕНИЕ ФУНКЦИИ АККЕРМАНА ======");
double firstNum  = UserInput("Введите 1-ое неотрицательное число");
double secondNum = UserInput("Введите 2-ое неотрицательное число");

System.Console.WriteLine($"Результат А({firstNum}, {secondNum}) = {CountAkkerman(firstNum, secondNum)}");
*/
