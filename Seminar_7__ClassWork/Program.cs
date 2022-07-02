/*Задача 46: Задайте двумерный массив размером m×n,
заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1*/

/*int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
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

int m = Input("Введите m: ");
int n = Input("Введите n: ");

int[,] numbers = new int[m, n];

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        numbers[i, j] = new Random().Next(1, 10);
    }
}

PrintArray(numbers);*/



/*Задача 48: Задайте двумерный массив размера m на n,
каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5*/

/*int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray2Lines(int[,] a)  //печать массива
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            Console.Write(a[i, j] + "  ");
        }
        Console.WriteLine();
    }
}

int m = Input("Введите m: ");
int n = Input("Введите n: ");

int[,] numbers = new int[m, n];

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        numbers[i, j] = i + j;
    }
}

PrintArray2Lines(numbers);*/


/*Задача 49: Задайте двумерный массив.
Найдите элементы, у которых оба индекса нечётные,
и замените эти элементы на их квадраты.
Например, изначально массив
 выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4*/


/*int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

int m = Input("Введите m: ");
int n = Input("Введите n: ");

int[,] numbers = new int[m, n];

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        numbers[i, j] = new Random().Next(10);
    }
}


void PrintArray2Lines(int[,] a)  //печать массива
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            Console.Write(a[i, j] + "  ");
        }
        Console.WriteLine();
    }
}
PrintArray2Lines(numbers);

for (int i = 1; i < numbers.GetLength(0); i += 2)
{
    for (int j = 1; j < numbers.GetLength(1); j += 2)
    {
        numbers[i, j] *= numbers[i, j];
    }
}
Console.WriteLine();
PrintArray2Lines(numbers);*/



/*Задача 51: Задайте двумерный массив.
Найдите сумму элементов, находящихся наглавной
диагонали (с индексами (0,0); (1; 1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12*/


/*int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

int m = Input("Введите m: ");
int n = Input("Введите n: ");

int[,] numbers = new int[m, n];

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        numbers[i, j] = new Random().Next(10);
    }
}


void PrintArray2Lines(int[,] a)  //печать массива
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            Console.Write(a[i, j] + "  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
PrintArray2Lines(numbers);

int result = 0;


for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        if (i == j)
        {
            result += numbers[i, j];
        }
    }
}
Console.WriteLine(result);*/

//VERSION__2

int m = Input("m=");
int n = Input("n=");
int[,] number = new int[m, n];

FillSeccondsArrayNumbers(number);
PrintSeccondArray(number);
Console.WriteLine();
int sum = 0;

for (int i = 0; i < number.GetLength(0); i++)
{
    for (int j = 0; j < number.GetLength(1); j++)
    {
        if (i == j)
        {
            if (i > 0 && j > 0)
            {
                Console.Write($"+{number[i, j]}");
            }
            else
            {
                Console.Write($"{number[i, j]}");
            }
            sum = sum + number[i, j];
        }
    }
}

Console.Write($"={sum}");
Console.WriteLine();
PrintSeccondArray(number);

void PrintSeccondArray(int[,] array)
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

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}


void FillSeccondsArrayNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 5);
        }
    }
}
