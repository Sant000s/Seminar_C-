// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

/*Console.Clear();
Console.WriteLine("Задайте параметры для двумерного массива");
Console.WriteLine();
int m = Input("Введите количество строк: ");
int n = Input("Введите количество столбцов: ");
Console.Clear();
Console.WriteLine("Двумерный массив согласно введенным данным:");
Console.WriteLine();
double[,] array = new double[m, n];
SetArray(array);
PrintArray(array);



int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

void SetArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
            arr[i, j] = Math.Round(arr[i, j], 1); // округление до одного знака после запятой
        }
    }
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == 0)
            {
                Console.Write(String.Format("{0, 6}", 0));
            }
            else
            {
                Console.Write(String.Format("{0, 6}", arr[i, j]));
            }
        }
        Console.WriteLine();
    }
}*/



// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание на то, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


/*Console.Clear();
int[,] array = new int[4, 3];
Console.WriteLine("Задан двумерный массив: ");
Console.WriteLine();
FillRandomArrayNumbers(array);
PrintArray(array);
Console.WriteLine();
int arrayNumbers = Input("Введите позицию элемента: ");
int line = arrayNumbers / 10 - 1;
int column = arrayNumbers % 10 - 1;
Console.WriteLine();

if (arrayNumbers < 10 || arrayNumbers > 99 || arrayNumbers % 10 == 0)
{
    Console.WriteLine("Ошибка! Введенное число должно быть двузначным!");
    Console.WriteLine();
}
else if (array.GetLength(0) > line && array.GetLength(1) > column)
{
    Console.WriteLine("Выбран элемент:  " + array[line, column]);
    Console.WriteLine();
}
else
{
    Console.WriteLine("Такого элемента в массиве нет!");
    Console.WriteLine();
}


int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

void FillRandomArrayNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 100);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}*/


// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в
// каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.Clear();
Console.WriteLine("\nЗадайте параметры для двумерного массива\n");
int m = Input("Введите количество строк: ");
int n = Input("Введите количество столбцов: ");
double averageNum = 0;
double totalSum = 0;
int[,] array = new int[m, n];
Console.WriteLine();
FillRandomArrayNumbers(array);
PrintArray(array);
Console.Write("\n\nСреднее арифметическое каждого столбца = \n");

for (int i = 0; i < array.GetLength(1); i++)
{
    averageNum = 0;
    for (int j = 0; j < array.GetLength(0); j++)
    {
        averageNum += array[j, i];
    }

    totalSum = Math.Round(averageNum / m, 1);

    if (i != array.GetLength(0) - 1)
    {
        Console.Write($"{totalSum}, ");

    }
    else Console.Write($"{totalSum}. ");
}


int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

void FillRandomArrayNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 10);
        }
    }

}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
