// Задайте двумерный массив. Напишите программу, которая 
// поменяет местами первую и последнюю строку массива.*/

// Console.WriteLine("введите номер строки");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите номер столбца");
// int m = Convert.ToInt32(Console.ReadLine());
// int[,] nums = new int[n, m];

// FillArrayRandomNumbers(nums);
// PrintArray(nums);


// for (int i = 0; i < nums.GetLength(1); i++)
// {
//     int temp = nums [0,i];
//     nums [0,i] = nums [nums.GetLength(1)-1, i];
//     nums [nums.GetLength(1)-1, i] = temp;

// }
// Console.WriteLine();
// PrintArray(nums);

/*int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}


void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
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



/*Задайте двумерный массив. Напишите программу, которая 
заменяет строки на столбцы. В случае, если это невозможно, 
программа должна вывести сообщение для пользователя.*/


// Console.WriteLine("введите номер строки");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите номер столбца");
// int m = Convert.ToInt32(Console.ReadLine());
// int[,] nums = new int[n, m];
// int[,] smun = new int[m, n];
// FillArrayRandomNumbers(nums);
// PrintArray(nums);

// if (n == m)
// {
//     for (int i = 0; i < nums.GetLength(0); i++)
//     {
//         for (int j = 0; j < nums.GetLength(1); j++)
//         {
//             smun[i, j] = nums[j, i];
//         }

//     }
//     Console.WriteLine();
//     PrintArray(smun);
// }
// else
// {
//     Console.WriteLine("Введите квадратный массив!!!");
// }



/*Составить частотный словарь элементов 
1, 2, 3 
4, 6, 1 
2, 1, 6
1 встречается 3 раза 
2 встречается 2 раз 
3 встречается 1 раз 
4 встречается 1 раз 
6 встречается 2 раза*/

// int m= InputInt("m");
// int n= InputInt("n");
// int[,] numbers = new int[n,m];

// FillArr2LinesRandom(numbers);
// PrintArray2Lines(numbers);
// int [] resultArray = new int[10];

// for (int i = 0; i < numbers.GetLength(0); i++)
// {
//     for (int j = 0; j < numbers.GetLength(1); j++)
//     {
//         resultArray[numbers[i,j]]++;
//     }
// }
// for (int i = 0; i < resultArray.Length; i++)
// {
//     if(resultArray[i]!=0)
//     {
//         Console.WriteLine($"{i} - Повторяется {resultArray[i]} раз;");
//     }
// }



// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит 
// строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

/*int row = Input("Введите число строк: ");
int column = Input("Введите число столбцов: ");
int[,] arrayInt = new int[row, column];

for (int i = 0; i < arrayInt.GetLength(0); i++)
{
    for (int j = 0; j < arrayInt.GetLength(1); j++)
    {
        arrayInt[i, j] = int.Parse(Console.ReadLine());
    }

}

PrintArray(arrayInt);
int minI = 0;
int minJ = 0;

for (int i = 0; i < arrayInt.GetLength(0); i++)
{
    for (int j = 0; j < arrayInt.GetLength(1); j++)
    {
        if (arrayInt[minI, minJ] > arrayInt[i, j])
        {
            minI = i;
            minJ = j;
        }
    }

}
int[,] newArrayInt = new int[arrayInt.GetLength(0) - 1, arrayInt.GetLength(1) - 1];

int indexI = 0;
int indexJ = 0;
for (int i = 0; i < newArrayInt.GetLength(0); i++)
{
    if (i == minI) indexI++;
    for (int j = 0; j < newArrayInt.GetLength(1); j++)
    {
        if (j == minJ) indexJ++;

        newArrayInt[i, j] = arrayInt[indexI, indexJ];
        indexJ++;
    }
    indexI++;
    indexJ = 0;

}

WriteLine();
PrintArray(newArrayInt);



Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника */


// int n = 10;

// int[,] pascal = new int[n, 2 * n + 1];
// pascal[0, n] = 1;
// for(int i = 1; i < n; i++)
// {
//     for(int j = n - i; j <= n + i; j++)
//     {
//         pascal[i, j] = pascal[i - 1, j - 1] + pascal[i - 1, j + 1];
//     }
// }

// string[] stringPascal = new string[n];
// for(int i = 0; i < n; i++)
// {
//     for(int j = n - i; j <= n + i; j++)
//     {
//         if(pascal[i, j] != 0)
//             stringPascal[i] += $"{pascal[i,j]}";
//         else
//             stringPascal[i] += " ";
//     }
// }

// int maxStringLength = stringPascal[stringPascal.Length - 1].Length;
// for(int i = 0; i < stringPascal.Length; i++)
// {
//     int countSpace = (maxStringLength - stringPascal[i].Length) / 2;
//     for(int j = 0; j < countSpace; j++)
//     {
//         Console.Write(" ");
//     }
//     Console.WriteLine(stringPascal[i]);
// }




// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы 
// каждого элемента.


int dimension1 = InputInt("Введите размерность 1: ");
int dimension2 = InputInt("Введите размерность 2: ");
int dimension3 = InputInt("Введите размерность 3: ");
int countNumbers = 89;

if (dimension1 * dimension2 * dimension3 > countNumbers)
{
    Console.WriteLine("Массив слишком большой!");
    return;
}

int[,,] numbers = CreateArray(dimension1, dimension2, dimension3);

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        for (int k = 0; k < numbers.GetLength(2); k++)
        {
            Console.Write($"[{i},{j},{k}] {numbers[i, j, k]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,,] CreateArray(int size1, int size2, int size3)
{
    int[,,] array = new int[size1, size2, size3];
    int[] digitValues = new int[countNumbers];
    int value = 10;
    for (int i = 0; i < digitValues.Length; i++)
        digitValues[i] = value++;

    for (int i = 0; i < digitValues.Length; i++)
    {
        int randomIndex = new Random().Next(0, digitValues.Length);
        int temp = digitValues[i];
        digitValues[i] = digitValues[randomIndex];
        digitValues[randomIndex] = temp;
    }

    int valueIndex = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = digitValues[valueIndex++];
            }
        }
    }

    return array;
}


int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}




// Задача 62: Заполните спирально массив 4 на 4.

/*Console.Write("Введите размерность массива: ");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[n, n];

int value = 1;
int i = 0;
int j = 0;

while (value <= n * n)
{
    array[i, j] = value;
    if (i <= j + 1 && i + j < n - 1)
        ++j;
    else if (i < j && i + j >= n - 1)
        ++i;
    else if (i >= j && i + j > n - 1)
        --j;
    else
        --i;
    ++value;
}

for (int x = 0; x < array.GetLength(0); x++)
{
    for (int y = 0; y < array.GetLength(1); y++)
    {
        Console.Write(array[x, y] + " ");
    }
    Console.WriteLine();
}*/
