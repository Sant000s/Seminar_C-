/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/


/*Console.Clear();
Console.WriteLine("Введите трехзначное число...");

int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int reduct = number / 10;
    int secondNumber = reduct % 10;
    Console.Write("Вторая цифра числа: " + secondNumber);
}
else
{
    Console.WriteLine("Число не является трехзначным!");
}*/



/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/


/*Console.Clear();
Console.WriteLine("Введите любое число...");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
{
    Console.Write("Третьей цифры нет!");
}
else
{
    while (number > 999)
    {
        number = number / 10;
    }

    int result = number % 10;
    Console.Write("Третья цифра числа: " + result);
}*/



/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/


/*Console.Clear();
Console.Write("Введите число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1 || number > 7)
{
    Console.WriteLine("Число не входит в интервал от 1 до 7! Ввведите другое число!");
}

if (number >= 1 && number <= 5)
{
    Console.WriteLine("Будний день!");
}

if (number == 6)
{
    Console.WriteLine("Выходной день: Суббота!");
}

if (number == 7)
{
    Console.WriteLine("Выходной день: Воскресенье!");
}*/


/*Доп. задача 16: Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет*/

Console.Clear();
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());


if (num1 / num2 == num2)
{
    Console.WriteLine(num1 + " является квадратом числа " + num2);
}

else
{
    Console.WriteLine(num1 + " НЕ является квадратом числа " + num2);
}
