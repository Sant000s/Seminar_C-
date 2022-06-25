/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

/*Console.Clear();
Console.Write("Введите первое число: ");
double a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
double b = Convert.ToInt32(Console.ReadLine());
double result = 1;

if (b >= 0)
{
    for (int i = 0; i < b; i++)
    {
        result = result * a;
    }
}

else
{
    for (int i = 0; i < -b; i++)
    {
        result = result * a;
    }
    result = 1 / result;
}

Console.WriteLine(result);*/


/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/


/*Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int res = 0;

while (num > 0)
{
    res = res + num % 10;
    num = num / 10;
}
Console.WriteLine(res);*/


/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Вывод сделать отдельным методом.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/


Console.Clear();
int[] array = new int[8];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(10);
}

Method(array);
Console.WriteLine();
string a = Metod2(array);
Console.Write(a);


void Metod(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

string Metod2(int[] arr)
{
    string result = string.Empty;

    for (int i = 0; i < arr.Length; i++)
    {
        result += array[i] + " ";
    }
    return result;
}