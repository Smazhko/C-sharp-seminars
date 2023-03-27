//Пользователь вводит с клавиатуры М числел. Посчитайте, 
//сколько чисел больше 0 ввёл пользователь
// 0, 7, 8, -2, -2 => 2

/*
Console.Write("Сколько чисел Вы хотите ввести? ");
int userCount = Convert.ToInt32(Console.ReadLine());
int positiveCounter = 0;

for(int i = 1; i <= userCount; i++)
{
    Console.Write($"Число №{i}: ");
    if (Convert.ToInt32(Console.ReadLine()) > 0) positiveCounter += 1;
}

if (positiveCounter>0) 
    Console.WriteLine($"В Вашем числовом ряду положительных чисел: {positiveCounter}.");
else
    Console.WriteLine($"В Вашем числовом ряду положительных чисел нет.");
*/

// Напишите программу, которая найдет точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1 и y = k1 * x + b1. 
// Значения k1, b1, k2, b2 задаются пользователем

// Если система уравнений:
// * имеет единственное решение, то прямые пересекаются;
// * имеет бесконечное множество решений, то прямые совпадают: k1 == k2 && b1 == b2
// * не имеет решений, то прямые не пересекаются (прямые параллельны между собой): если k1 == k2

// решаем задачу в общем виде
// k1 * x + b1 = k2 * x + b2
// k1 * x - k2 * x =  b2 - b1
// x * (k1 - k2) = b2 - b1
// x = (b2 - b1) / (k1 - k2)

double UserInput(string message)
{
    Console.Write(message + "... ");
    int num = Convert.ToInt32(Console.ReadLine());

    return num;
}

Console.WriteLine("ПОИСК ТОЧКИ ПЕРЕСЕЧЕНИЯ ДВУХ ПРЯМЫХ НА ПЛОСКОСТИ");
double k1 = UserInput("Первая прямая y = k1*x + b1. Введите k1");
double b1 = UserInput("Первая прямая y = k1*x + b1. Введите b1");
double k2 = UserInput("Вторая прямая y = k2*x + b2. Введите k2");
double b2 = UserInput("Вторая прямая y = k2*x + b2. Введите b2");

double x = 0;
double y = 0;

Console.WriteLine();

if (k1 == k2 && b1 == b2)
    Console.WriteLine("Ответ: данные прямые совпадают.");
else if (k1 == k2)
    Console.WriteLine("Ответ: данные прямые параллельны.");
else
{
    x = (b2 - b1) / (k1 - k2);
    y = (k1 * x + b1);
    Console.WriteLine($"Ответ: данные прямые пересекаются в точке [{Math.Round(x, 1)}; {Math.Round(y, 1)}].");
}