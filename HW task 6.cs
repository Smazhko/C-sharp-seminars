//Пользователь вводит с клавиатуры М числел. Посчитайте, 
//сколько чисел больше 0 ввёл пользователь
// 0, 7, 8, -2, -2 => 2


int CountPositives(int quantity)
{
    int positiveCounter = 0;
    
    for(int i = 1; i <= quantity; i++)
    {
    Console.Write($"Число №{i} из {quantity}: ");
    if (Convert.ToInt32(Console.ReadLine()) > 0) positiveCounter += 1;
    }

    return positiveCounter;
}

Console.Write("Сколько чисел Вы хотите ввести? ");
int userQuantity = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"В Вашем числовом ряду положительных чисел: {CountPositives(userQuantity)}.");


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

/*
double UserInput(string message)
{
    Console.Write(message + "... ");
    int num = Convert.ToDouble(Console.ReadLine());

    return num;
}

string IsCross (double k1, double b1, double k2, double b2)
{
    double x = 0;
    double y = 0;
    
    if (k1 == k2 && b1 == b2)
        return "совпадают";
    else if (k1 == k2)
        return "параллельны";
    else
    {
        x = (b2 - b1) / (k1 - k2);
        y = (k1 * x + b1);
        return $"пересекаются в точке [{Math.Round(x, 1)}; {Math.Round(y, 1)}]";
    }
}


Console.WriteLine("ПОИСК ТОЧКИ ПЕРЕСЕЧЕНИЯ ДВУХ ПРЯМЫХ НА ПЛОСКОСТИ\n");
double k1 = UserInput("Первая прямая y = k1*x + b1. Введите k1");
double b1 = UserInput("                             Введите b1");
double k2 = UserInput("Вторая прямая y = k2*x + b2. Введите k2");
double b2 = UserInput("                             Введите b2");

Console.WriteLine($"\nОтвет: прямые y={k1}x+{b1} и y={k2}x+{b2} {IsCross (k1, b1, k2, b2)}.");
*/