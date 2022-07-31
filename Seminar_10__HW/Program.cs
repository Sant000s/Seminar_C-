// Задача 73: Есть число N. Сколько групп M, можно получить при разбиении всех чисел на группы, так чтобы в одной группе 
// все числа в группе друг на друга не делились? Найдите M при заданном N и получите одно из разбиений на группы N ≤ 10²⁰.

// Например, для N = 50, M получается 6
// Группа 1: 1
// Группа 2: 2 3 11 13 17 19 23 29 31 37 41 43 47
// Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49
// Группа 4: 8 12 18 20 27 28 30 42 44 45 50
// Группа 5: 7 16 24 36 40
// Группа 6: 5 32 48

// Группа 1: 1
// Группа 2: 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47
// Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49
// Группа 4: 8 12 18 20 27 28 30 42 44 45 50
// Группа 5: 16 24 36 40
// Группа 6: 32 48


/*Console.Clear();
int n = Input("\nВведите значение числа N: ");
Console.WriteLine();
int[] tempArray = PrintArray(n);
PrintGroup(tempArray);

void PrintGroup(int[] arrayCheck)
{
    int[] array = new int[arrayCheck.Length];
    int m = 1;
    int count = 0;
    int tempNumber = 0;
    int tempNumber2 = 0;
    int tempSwitch = 0;

    for (int i = 0; i < arrayCheck.Length; i++)
    {
        Array.Clear(array);
        count = 0;
        if (arrayCheck[i] != 0)
        {
            array[count] = arrayCheck[i];
            tempNumber2 = arrayCheck[i];

            for (int j = i; j < arrayCheck.Length; j++)
            {
                if (arrayCheck[j] % tempNumber2 != 0 || arrayCheck[j] / tempNumber2 == 1)
                {
                    tempSwitch = 0;
                    tempNumber = arrayCheck[j];
                    for (int k = 0; k < count; k++)
                    {
                        if (tempNumber % array[k] == 0) tempSwitch++;
                    }
                    if (tempSwitch == 0)
                    {
                        array[count] = arrayCheck[j];
                        count++;
                        arrayCheck[j] = 0;
                    }
                }
            }
            Console.WriteLine($"Группа {m++}: {PrintIntArray(array)}");
        }
    }
}

int Input(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int[] PrintArray(int n)
{
    int[] temp = new int[n];
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = i + 1;
    }
    return temp;
}

string PrintIntArray(int[] array)
{
    string result = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != 0) result += $"{array[i],1} ";
    }
    return result;
}*/



// Дополнительная задача 74*: 4 друга должны посетить 12 пабов, в котором выпить по британской пинте пенного напитка.
// До каждого бара идти примерно 15-20 минут, каждый пьет пинту за 15 минут. У первого друга лимит выпитого 1.1 литра,
// у второго 1.5, у третьего 2.2 литра, у 4 - 3.3 литра, это их максимум. Необходимо выяснить, до скольки баров смогут
// дойти каждый из друзей(Пройденное расстояние (в барах)), пока не упадет. И сколько всего времени будет потрачено на выпивку.


double[] frendsLimit = new double[] { 1.1, 1.5, 2.2, 3.3 };
int speedDrinking = 15;
int[] walkingSpeed = new int[] { 15, 20 };
int travelTime = 0;
int pubsQuantity = 12;
double pint = 0.56826125;
int timeСounter = 0;

for (int j = 0; j <= frendsLimit.Length - 1; j++)
{
    int count = 0;
    travelTime = -17;

    while (frendsLimit[j] > 0)
    {
        frendsLimit[j] -= pint;
        count++;
        travelTime = travelTime + new Random().Next(walkingSpeed[0], walkingSpeed[1] + 1);
    }

    timeСounter = travelTime + speedDrinking * count;

    if (count > pubsQuantity) Console.WriteLine($"Друг № {j + 1} пошел на 2-й круг и упадёт в {count - 12} баре через {timeСounter / 60} часов {timeСounter % 60} минут");
    else
    {
        Console.WriteLine($"Друг № {j + 1} упадёт в {count} баре через {timeСounter / 60} часов {timeСounter % 60} минут");
    }
}