// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"


/*int number = int.Parse(Console.ReadLine());
Console.WriteLine(NaturalNumber(number));

int NaturalNumber(int number)
{
    if (number == 1)
        return number;
    else
        Console.Write($"{NaturalNumber(number - 1)}, ");

    return number;
}*/


// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5-> "1, 2, 3, 4, 5"
// M = 4; N = 8-> "4, 6, 7, 8"

/*Console.Clear();
int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

int m = Input("Insert first number: ");
int n = Input("Insert second number: ");

int PrintNumNatur(int m, int n)
{
    if (m == n)
        return n;

    else
    {
        Console.Write($"{PrintNumNatur(m, n - 1)}, ");
    }
    return n;
}
Console.WriteLine(PrintNumNatur(m, n));*/


// ВЕРСИЯ 2

/*int m = InputInt("Задайте число m: ");
int n = InputInt("Задайте число n: ");
Console.WriteLine(NaturalNumber(m, n));

int NaturalNumber(int m, int n)
{
    if (m == n)
    {
        return n;
    }
    if (m < n)
    {
        Console.Write($"{NaturalNumber(m, n - 1)}, ");
    }
    if (m > n)
    {
        Console.Write($"{NaturalNumber(m, n + 1)}, ");
    }

    return n;
}

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}*/


// ВЕРСИЯ 3:

/*int m = InputInt("Задайте число m: ");
int n = InputInt("Задайте число n: ");
NaturalNumber(m, n);
 
void NaturalNumber(int m, int n)
{
    if (m == n)
    {
        Console.Write($"{m} ");
    } 
    if (m < n)
    {
        Console.Write($"{m}, ");
        NaturalNumber(m + 1, n);
    }
    if (m > n)
    {
        Console.Write($"{m}, ");
        NaturalNumber(m - 1, n);
    }
}

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}*/



// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


// метод ввода чисел
int InputNum(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int NumberSum(int number)
{
    if (number < 0)
        number = -number;

    if (number == 0)
        return 0;

    return number % 10 + NumberSum(number / 10);
}

int number = InputNum("Input number: ");
Console.WriteLine(NumberSum(number));



// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А возведенную в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// VAR1:

/*int Power(int a, int b)
{
    if (b == 0)
        return 1;

    return a * Power(a, b - 1);
}

int A = InputNum("Input A: ");
int B = InputNum("Input B: ");

Console.WriteLine(Power(A, B));*/

// VAR2: с отрицательными числами

/*double Power(double a, int b)
{

    if (b == 0)
        return 1;

    if (b < 0)
        return 1 / a * Power(a, b + 1);
    else
        return a * Power(a, b - 1);
}

int A = InputNum("Input A: ");
int B = InputNum("Input B: ");

Console.WriteLine(Power((double)A, B));*/




