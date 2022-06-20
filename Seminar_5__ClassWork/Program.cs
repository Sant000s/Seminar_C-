/*Задача 31: Задайте массив из 12 элементов, заполненный 
случайными числами из промежутка [-9, 9]. Найдите сумму 
отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма 
положительных чисел равна 29, сумма отрицательных равна -20.*/


/*int[] array = new int[12];
int sumPositive = 0;
int sumNegative = 0;

FillArrayRandomNumbers(array);
PrintArray(array);

for(int i = 0; i < array.Length; i++)
{
    if(array[i] > 0)
        sumPositive += array[i];
    else
        sumNegative += array[i];
}
Console.WriteLine($"Сумма положительных = {sumPositive}, сумма отрицательных = {sumNegative}");


void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void FillArrayRandomNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
}*/



/*Задача 32: Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие отрицательные,
 и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]*/


/*int[] num = { -4, -8, 8, 2 };

for (int i = 0; i < num.Length; i++)
{
    num[i] *= -1;
    Console.Write(num[i] + " ");
}*/



/*Задача 33: Задайте массив.Напишите программу, которая определяет,
 присутствует ли заданное число в массиве.
4; массив[6, 7, 19, 345, 3]->нет
3; массив[6, 7, 19, 345, 3]->да*/


/*int[] num = new int[5];
Console.Write("Введите число от 0 до 9: ");
int temp = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < num.Length; i++)
{
    num[i] = new Random().Next(10);
    Console.Write(num[i] + " ");
}

bool Found = false;

for (int i = 0; i < num.Length; i++)
{
    if (num[i] == temp)
    {
        Found = true;
        i = num.Length;
    }
}

if (Found)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}*/





/*int size = InputInt("Введите размер массива: ");
int[] array = CreateArray(size);
PrintArray(array);

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = InputInt("Введите элемент " + i + ": ");
    }
    return array;
}

int InputInt(string outout)
{
    Console.Write(outout);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}*/



/*Задача 35: Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в 
отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении 
сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5*/


/*int[] arr = new int[123];

for(int i=0; i<arr.Length; i++)
{
    arr[i] = new Random().Next(1000);
    Console.Write(arr[i] + " ");
}

int counter = 0;
for(int i=0; i<123; i++)
{
    if(arr[i] >= 10 && arr[i] <= 99) 
        counter++;
}

Console.WriteLine();
Console.WriteLine(counter);*/



/*Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21*/

//ВАРИАНТ № 1

/*Console.Clear();
Console.Write("Size of array: ");
int arrSize = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[arrSize];

for(int i=0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(1000);
    Console.Write(arr[i] + " ");
}

int[] newArr;
// проверить на четность размер массива
if(arr.Length % 2 == 0)
{
    newArr = new int[arr.Length / 2];
}
else
{
    newArr = new int[arr.Length / 2 + 1];
}

Console.WriteLine();

int j = 0;
while(j < arr.Length / 2)
{
    newArr[j] = arr[j] * arr[arrSize - 1 - j];
    Console.Write(newArr[j] + " ");
    j++;
}

if(arr.Length % 2 != 0)
{
    newArr[j] = arr[j];
    Console.Write(newArr[j] + " ");
}*/


//ВАРИАНТ № 2

/*int size = Input("Введи размер: ");
int[] array = new int[size];
int[] arr2;
int size2;
FillArrayRandomNumbers(array);
PrintArray(array);
if(size%2 == 0)
{
    size2=size/2;
    arr2= new int[size2];
}
else
{
    size2=(size/2)+1;
    arr2= new int[size2];
    arr2[size2-1]=array[size2-1];
}
for(int i = 0; i < array.Length/2; i++)
{
    arr2[i] = array[i]*array[array.Length-1-i];
}
PrintArray(arr2);

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void FillArrayInputNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Input("Число:");
    }
}
int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
void FillArrayRandomNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 5);
    }
}*/

