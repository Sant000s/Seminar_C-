/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2; b = 10 -> max = 10
a = -9; b = -3 -> max = -3*/


/*Console.Clear();
Console.WriteLine("Введите первое число...");

int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число...");

int b = Convert.ToInt32(Console.ReadLine());

int max = a;

if (max < b)
{
    max = b;
}

Console.Write("Большее число: " + max);*/



/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2 3 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/


/*Console.Clear();
Console.WriteLine("Insert first number...");

int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insert second number...");

int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insert third number...");

int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (max < b)
{
    max = b;
}

if (max < c)
{
    max = c;
}

Console.Write("Maximum number is..." + max);*/


/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет*/


/*Console.Clear();
Console.Write("Введите любое число: ");

int digit = Convert.ToInt32(Console.ReadLine());

if (digit % 2 == 0)
{
    Console.WriteLine("Является четным!");
}
else
{
    Console.WriteLine("Не является четным!");
}*/



/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/


Console.Clear();
Console.WriteLine("Введите любое число...");

int N = Convert.ToInt32(Console.ReadLine());
int sum = 1;
Console.WriteLine("Все четные числа из интервала от 1 до " + N);
while (sum <= N)
{
    if (sum % 2 == 0)
    {
        Console.Write(sum + " ");
    }
    sum++;
}
