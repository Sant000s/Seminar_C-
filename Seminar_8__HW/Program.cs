// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

/*int[,] table =
{
    {8, 5, 1, 4},
    {9, 0, 3, 6},
};

PrintArray(table);
Console.WriteLine();

for (int k = 0; k < table.GetLongLength(1); k++)
{

    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1) - 1; j++)
        {
            if (table[i, j] < table[i, j + 1])
            {
                int temp = table[i, j];
                table[i, j] = table[i, j + 1];
                table[i, j + 1] = temp;
            }

        }
    }
}

PrintArray(table);

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

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/*Console.Clear();
int[,] arrayRect = new int[4, 5];
Console.WriteLine("\nЗадан прямоугольный двумерный массив размером 4 х 5: \n");
FillRandomArrayNumbers(arrayRect);
PrintArray(arrayRect);
Console.WriteLine();
int minSumm = int.MaxValue;
int lineIndex = 0;

for (int i = 0; i < arrayRect.GetLength(0); i++)
{
    int summ = 0;
    for (int j = 0; j < arrayRect.GetLength(1); j++)
    {
        summ += arrayRect[i, j];

        if (summ < minSumm)
        {
            minSumm = summ;
            lineIndex = i;
        }
    }
}

Console.WriteLine($"Наименьшая сумма элементов находится в строке № {lineIndex + 1}\n");


void FillRandomArrayNumbers(int[,] array)
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


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Умножать матрицы можно тогда и только тогда, когда количество столбцов первой матрицы A равно количеству строк второй матрицы B.
// В обратном порядке умножить данные матрицы невозможно, так как количество столбцов матрицы B не совпадёт с количеством строк матрицы A.


/*Console.Clear();
int[,] arrayFirst = new int[4, 5];
int[,] arraySec = new int[5, 4];
FillRandomArrayNumbers(arrayFirst);
FillRandomArrayNumbers(arraySec);
PrintArray(arrayFirst);

Console.WriteLine();

PrintArray(arraySec);*/

//int[,] arrayResult = new int[arrayFirst.GetLength(0), arraySec.GetLength(1)];

/*for (int i = 0; i < arrayResult.GetLength(0); i++)
{
    for (int j = 0; j < arrayResult.GetLength(1); j++)
    {
        for (int k = 0; k < arrayResult.GetLength(0); k++)
        {
            arrayResult[i, j] = arrayResult[i, j] + arrayFirst[i, k] * arraySec[k, j];
        }
    }
}*/

/*Console.WriteLine();

MatrixProduct(arrayFirst, arraySec);

//PrintArray(arrayResult);


void MatrixProduct(int[,] firstArr, int[,] secondArr)
{
    int[,] resultArr = new int[firstArr.GetLength(0), secondArr.GetLength(1)];

    for (int i = 0; i < firstArr.GetLength(0); i++)
    {
        for (int j = 0; j < secondArr.GetLength(1); j++)
        {
            int result = 0;
            for (int c = 0; c < secondArr.GetLength(0); c++)
            {
                result += firstArr[i, c] * secondArr[c, j];
            }
            resultArr[i, j] += result;
        }
    }
    PrintArray(resultArr);

}


void FillRandomArrayNumbers(int[,] array)
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

// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет 
// построчно выводить массив, добавляя индексы каждого элемента.

/*Console.Clear();
Console.WriteLine("\nФормируем трехмерный массив из неповторяющихся двузначных чисел.\n");
Console.WriteLine($"\nВведите размер массива в трехмерной плоскости: X; Y; Z\n");
int x = Input("Введите размер X: ");
int y = Input("Введите размер Y: ");
int z = Input("Введите размер Z: ");
Console.WriteLine();
int maxCount = 89;

if (x * y * z > maxCount)
{
    Console.WriteLine("\nОШИБКА!!! Переволнение допустимого количества элементов в массиве!\n");
    Console.WriteLine("Попробуйте задать меньше размерность плоскостей!\n");
    return;
}
Console.WriteLine("=================================================================");

int[,,] array3D = new int[x, y, z];
FillArray(array3D);
PrintArray(array3D);

int Input(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void PrintArray(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write(String.Format("{0, 4}", array3D[i, j, k]));
                Console.Write($" | [{i}, {j}, {k}]");
            }
            Console.WriteLine();
        }
        Console.WriteLine("=================================================================");
    }
}

void FillArray(int[,,] array3D)
{
    int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
    int number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 100);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < array3D.GetLength(0); x++)
    {
        for (int y = 0; y < array3D.GetLength(1); y++)
        {
            for (int z = 0; z < array3D.GetLength(2); z++)
            {
                array3D[x, y, z] = temp[count];
                count++;
            }
        }
    }
}*/



// Задача 62: Заполните спирально массив 4 на 4.
// Например:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7


Console.Clear();
Console.WriteLine("\nФормируем спиральный массив 4 х 4: \n");
int n = 4; // сработает для любого числа
int temp = 1;
int i = 0;
int j = 0;
int[,] spiralArray = new int[n, n];

while (temp <= spiralArray.GetLength(0) * spiralArray.GetLength(1))
{
    spiralArray[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < spiralArray.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= spiralArray.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > spiralArray.GetLength(1) - 1)
        j--;
    else
        i--;
}

PrintArray(spiralArray);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
                Console.Write($" {array[i, j]} ");

            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
