// задача 2.=======================================================
// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// ================================================================
/*
int InputNum (string message)
{
    Console.Write(message);
    int userNum = Convert.ToInt32(Console.ReadLine());
    return userNum;
}

int FindMax (int num1, int num2)
{
    if (num1 > num2)
        return num1;
    else
        return num2;
}

int FindMin (int num1, int num2)
{
    if (num1 < num2)
        return num1;
    else
        return num2;
}

int userNum1 = InputNum("Введите первое число... ");

int userNum2 = InputNum("Введите второе число... ");

int max = FindMax(userNum1, userNum2);
int min = FindMin(userNum1, userNum2);

System.Console.WriteLine($"Максимальное число из пары = {max}, минимальное = {min}.");

// ------------ И Л И   П Р О Щ Е -----------------------------------

Console.Write("Введите первое число... ");
int userNumb1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число... ");
int userNumb2 = Convert.ToInt32(Console.ReadLine());

int maxN = userNum1;
int minN = userNum2;

if (userNumb1 < userNumb2)
{
    minN = userNumb1;
    maxN = userNumb2;
}

System.Console.WriteLine($"Максимальное число из пары = {maxN}, минимальное = {minN}.");
*/

// ------------------------------------------------------------------
// задача 4.=========================================================
// Напишите программу, которая принимает на вход 
// три числа и выдаёт максимальное из этих числел.
// ==================================================================
/*
int InputNum (string message)
{
    Console.Write(message);
    int userNum = Convert.ToInt32(Console.ReadLine());
    return userNum;
}

int FindMax (int num1, int num2, int num3)
{
    int max = num1;
    if (num2 > max)
        max = num2; 
    if (num3 > max) 
        max = num3;
    return max;
}

int userNum1 = InputNum("Введите первое число... ");
int userNum2 = InputNum("Введите второе число... ");
int userNum3 = InputNum("Введите третье число... ");

System.Console.WriteLine("Максимальное из этих трёх чисел = " + FindMax(userNum1, userNum2, userNum3));
*/
// задача 6.=========================================================
// Напишите программу, которая на фход принимает число и выдает,
// является ли число чётным (делится ли оно на 2 без остатка).
// ==================================================================
/*
string IsEven (int num)
{
    if (num % 2 == 0)
        return "ЧЁТНОЕ";
    else
        return "НЕЧЁТНОЕ";
}

Console.Write("Введите число для проверки чётности... ");
int userNum = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Введённое число {IsEven(userNum)}.");

*/
// Задача 8. ========================================================
// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// ==================================================================
/*
void NumList (int num)
{
    Console.WriteLine("Чётные числа от 1 до введенного числа:");
    
    if (num < 2)
        System.Console.WriteLine("отсутствуют >.<");
    int count = 2;
    
    while(count <= num)
    {
        if (count % 2 == 0)
            System.Console.Write(count + " ");
        count += 1;
    }
}

Console.Write("Введите положительное целое число... ");
int userNum = Convert.ToInt32(Console.ReadLine());

NumList(userNum);
*/
// задача 10. =======================================================
// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// ==================================================================
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

// задача 13. ======================================================
// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// =================================================================

// --- C П О С О Б   Б Е З   М А С С И В А -------------------------

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

int FindThirdDidit (int num)
{
    return num / Convert.ToInt32(Math.Pow(10, CountDigits(num) - 3)) % 10;  
    //остаток от деления заданного числа на 10 в степени (разряд числа минус три)
}

Console.Write("Введите целое число... ");
int userNum = Convert.ToInt32(Console.ReadLine());

if (userNum >= 100)
    Console.WriteLine("Третья цифра указанного числа: " + FindThirdDidit(userNum));
else
    Console.WriteLine("У числа нет третьей цифры >.<");


// --- C П О С О Б   С   М А С С И В О М ----с настраиваемым выводом нужной цифры-
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
//берем модуль числа на случай ввода пользователей отрицательного
int userNum = Math.Abs(Convert.ToInt32(Console.ReadLine())); 
int needDigit = 3;   // необходимо вывести третью цифру, но можно поменять

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
