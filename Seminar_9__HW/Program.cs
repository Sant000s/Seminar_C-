// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1
// N = 5-> "5, 4, 3, 2, 1"
// N = 8-> "8, 7, 6, 5, 4, 3, 2, 1"

/*Console.Clear();
int n = Input("Введите любое целое число: ");
Console.WriteLine();
int count = 2;
PrintArray(n, count);
Console.Write("1");

void PrintArray(int n, int count)
{
    if (count > n)
        return;
    PrintArray(n, count + 1);
    Console.Write(count + ", ");
}

int Input(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30

/*Console.Clear();
Console.WriteLine($"\nТребуется найти сумму натуральных элементов в промежутке от M до N\n");
int m = Input("Введите значение числа M: ");
int n = Input("Введите значение числа N: ");
int temp = m;

if (m > n)
{
    m = n;
    n = temp;
    Console.WriteLine();
}

PrintSumm(m, n, temp = 0);
Console.WriteLine();

void PrintSumm(int m, int n, int summ)
{
    summ = summ + n;
    if (n <= m)
    {
        Console.Write($"\nСумма элементов в заданном промежутке  = {summ}\n");
        return;
    }
    PrintSumm(m, n - 1, summ);
}


int Input(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3->A(m, n) = 9
// m = 3, n = 2->A(m, n) = 29


Console.Clear();
Console.WriteLine($"\nТребуется вычислить функцию Аккермана с помощью рекурсии из двух неотрицательных чисел M и N.\n");
int m = Input("Введите значение числа M: ");
int n = Input("Введите значение числа N: ");

int funAkkerman = Akkerman(m, n);

Console.Write($"\nФункция Аккермана = {funAkkerman} ");

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Akkerman(m - 1, 1);
    else return Akkerman(m - 1, Akkerman(m, n - 1));
}

int Input(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}