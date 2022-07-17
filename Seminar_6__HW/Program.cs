// Задача 41: Пользователь вводит с клавиатуры числа через запятую. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


Console.Clear();
Console.Write("Введите числа через запятую: ");

int[] StringToArr(string input)
{
    int countNum = 1;

    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
        {
            countNum++;
        }
    }

    int[] array = new int[countNum];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string tempString = "";

        while (input[i] != ',')
        {
            if (i != input.Length - 1)
            {
                tempString += input[i].ToString();
                i++;
            }
            else
            {
                tempString += input[i].ToString();
                break;
            }
        }

        array[index] = Convert.ToInt32(tempString);
        index++;
    }

    return array;
}


int[] array = StringToArr(Console.ReadLine());

int countPositive = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        countPositive += 1;
    }
}

Console.WriteLine();
Console.Write($"Количество чисел больше нуля, введенных пользователем, равна {countPositive}");




//Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)