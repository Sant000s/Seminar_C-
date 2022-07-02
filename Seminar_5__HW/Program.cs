// Внимание, внимание! Начиная с этого дз при оценке учитывается оформление
// и названия переменных. Будьте в нимательны!!!

/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными
числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/


/*Console.Clear();
Console.Write("Введите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int[] array = new int[sizeArray];
int count = 0;
int sum = 0;

CreateArray(array);

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        count = array[i] / array[i];
        sum += count;
    }
}
Console.WriteLine();
Console.WriteLine("Колличество четных чисел в массиве: " + sum);


void CreateArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write(array[i] + " ");
    }
}*/

/*Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6]-> 0*/


/*Console.Clear();
Console.Write("Введите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int[] array = new int[sizeArray];
int sum = 0;

CreateArray(array);

for (int i = 0; i < array.Length; i += 2)
{
    sum += array[i];
}
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {sum}");


void CreateArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100);
        Console.Write(array[i] + " ");
    }
}*/

/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
[3 7 22 2 78] -> 76*/


Console.Clear();
Console.Write("Введите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int[] array = new int[sizeArray];

Console.Clear();
CreateArray(array);
int min = array[0];
int max = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }

    else if (array[i] < min)
    {
        min = array[i];
    }
}

Console.WriteLine();
Console.Write($"Разница между максимальным и минимальным элементом массива:  {max - min}");


void CreateArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
        Console.Write(array[i] + " ");
    }
}
