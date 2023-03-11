// задача 2.
// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

// ------------------------------------------------------------------
// задача 4.
// Напишите программу, которая принимает на вход 
// три числа и выдаёт максимальное из этих числел.

// ------------------------------------------------------------------
// задача 6.
// Напишите программу, которая на фход принимает число и выдает,
// является ли число чётным (делится ли оно на 2 без остатка).
// ------------------------------------------------------------------
// Задача 8. 
// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// ------------------------------------------------------------------
// задача 10. 
// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
/*
int FindSecondDigit (int num)
{
    return (num / 10) % 10;
}

int userNum;

while (true)
{
    Console.Write("Введите трёхзначное число: ");
    userNum = Convert.ToInt32(Console.ReadLine());
    if (userNum >=100 && userNum <=999) 
        break;
}

Console.WriteLine("Вторая цифра введенного числа - " + FindSecondDigit(userNum));
*/
// ------------------------------------------------------------------
// задача 13. 
// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// --- C П О С О Б   Б Е З   М А С С И В А --------------------------
/*
int CountDigits (int num)
{    
    int digsCount = 0;
    int temp = num;
    while (temp > 0)
    {
        temp = temp / 10;
        digsCount = digsCount + 1;
    }
    return digsCount;
}

Console.Write("Введите целое число: ");
int userNum = Convert.ToInt32(Console.ReadLine());

if (CountDigits(userNum) >= 3)
{
    int thirdDidit = userNum / Convert.ToInt32(Math.Pow(10, CountDigits(userNum)-3)) % 10;
    Console.WriteLine("Третья цифра указанного числа - " + thirdDidit);}
else
{
    Console.WriteLine("У числа нет третьей цифры :(");
}
*/

// --- C П О С О Б   С   М А С С И В О М ----с настраиваемым выводом нужной цифры--------
/*
int FindNeedDigit(int num, int digit) 
//разделяет введенное число на отдельные цифры и выдает нужную по счету
{    
    int[] ArrDigits = new int[10];//10 разрядов у INT32
    int digNumber = 0;
    while (num > 0)
    {
        ArrDigits[digNumber] = num % 10; //отсекаем последнюю цифру у числа и записываем в массив
        num = num / 10;
        digNumber = digNumber + 1;
    }
    return ArrDigits[digNumber - digit];
}

Console.Write("Введите целое число: ");
int userNum = Math.Abs(Convert.ToInt32(Console.ReadLine())); //берется модуль числа на случай отрицательного
int needDigit = 3;       // необходимо вывести третью цифру, но можно поменять

if (userNum > Math.Pow(10, needDigit - 1) -1) 
//проверка - если введенное число не сожержит желаемую по счету цифру
    Console.WriteLine($"{needDigit}-я цифра указанного числа - " + FindNeedDigit(userNum, needDigit));
else
    Console.WriteLine($"У числа нет {needDigit}-й цифры :(");

*/
// ------------------------------------------------------------------
// задача 15.
// Напишите программу, которая принимает на вход цифру, обозначающую 
// день недели, и проверяет, является ли этот день выходным.

/*
string IsVacation(int day)
{
    if (day == 6 || day == 7)
        return "выходной день";
    else
        return "будний день";
}

int dayOfWeek;

while (true)
{
    System.Console.Write("Введите цифру (день недели) от 1 до 7: ");
    dayOfWeek = Convert.ToInt32(Console.ReadLine());
    if (dayOfWeek >=1 && dayOfWeek <=7) 
        break;
}

System.Console.WriteLine($"Выбранный Вами день недели - {IsVacation(dayOfWeek)}.");
*/
