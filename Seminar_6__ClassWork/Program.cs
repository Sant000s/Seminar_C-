/*Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]*/


//VERSUS__1
/*int[] numbers = { 1, 2, 3, 4, 5, 6 };

for (int i = 0; i < numbers.Length / 2; i++)
{
    int temp = numbers[i];
    numbers[i] = numbers[numbers.Length - 1 - i];
    numbers[numbers.Length - 1 - i] = temp;
}

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");
}*/

//VERSUS__2 - через создание второго массива
/*Console.Clear();
int[] numbers = { 1, 2, 3, 4, 5, 6 };
int[] tempArray = new int[numbers.Length];

for (int i = 0; i < numbers.Length; i++)
{
    tempArray[i] = numbers[numbers.Length - 1 - i];
}

numbers = tempArray;

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");
}*/


/*Задача 40: Напишите программу, которая принимает на вход три числа
и проверяет, может ли существовать треугольник с сторонами такой
длины.
Подсказка: Теорема о неравенстве треугольника: каждая сторона
треугольника меньше суммы двух других сторон.*/

/*Console.WriteLine("Enter three numbers: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

if (a < (b+c) && b < (a+c) && c < (a+b) )
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}*/


/*Задача 42: Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10*/


/*Console.Clear();
Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
string result = String.Empty;

while (num > 0)
{
    result = Convert.ToString(num % 2) + result;
    num = num / 2;
}

Console.WriteLine(result);*/


/*Задача 44: Не используя рекурсию, выведите первые N чисел
Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8*/


/*int num = Input("Введите число N: ");
int[] arr = new int[num];
arr[0] = 0;
if (num == 1)
{
    Console.WriteLine(arr[0]);
}
else
{
    arr[1] = 1;
    for (int i = 2; i < num; i++)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
    }
    PrintArray(arr);

    // Метод

    void PrintArray(int[] array)
    {
        string print = "[";
        for (int i = 0; i < array.Length; i++)
        {
            if (i == array.Length - 1)
            {
                print += array[i];
                break;
            }
            print += array[i] + ", ";
        }
        Console.Write(print + "]\n");
    }
}

int Input(string str)
{
    Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}*/


/*Задача 45: Напишите программу, которая будет создавать копию
заданного массива с помощью поэлементного копирования.*/


int[] arr = { 3, 2, 7, 9, -3, 0, 1 };
int[] cloneArr = new int[arr.Length];
PrintArray(arr);
for (int i = 0; i < arr.Length; i++)
{
    cloneArr[i] = arr[i];
}
PrintArray(cloneArr);

// Метод
void PrintArray(int[] array)
{
    string print = "[";
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            print += array[i];
            break;
        }
        print += array[i] + ", ";
    }
    Console.Write(print + "]\n");
}
