// Задача 41: Пользователь вводит с клавиатуры числа через запятую. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


/*Console.Clear();
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
            tempString += input[i].ToString();

            if (i == input.Length - 1)
            {
                break;
            }

            i++;
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
Console.Write($"Количество чисел больше нуля равно {countPositive}");*/



//Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями 

// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// К примеру,
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)


// ПРИРАВНИВАЕМ ОБА ЗНАЧЕНИЯ Y: k1x + b1 = k2x + b2
// ГРУППИРУЕМ: k1x - k2x = b2 - b1
// НАХОДИМ Х: x = (b2 - b1) / (k1 - k2)
// ДАЛЕЕ ПОДСТАВЛЯЕМ В ФОРМУЛУ КОДА


Console.Clear();
double Input(string output)
{
    Console.Write(output);
    return Convert.ToDouble(Console.ReadLine());
}

double k1 = Input("Введите значение k1: ");
double b1 = Input("Введите значение b1: ");
double k2 = Input("Введите значение k2: ");
double b2 = Input("Введите значение b2: ");

if (k1 == k2)
{
    Console.WriteLine("Прямые параллельны!");
    return;
}

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"Координата точки x = {x}, координата точки y = {y}");
