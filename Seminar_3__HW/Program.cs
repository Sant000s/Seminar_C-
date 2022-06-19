/*Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да*/


/*Console.Clear();
Console.Write("Введите пятизначное число: ");

int number = Convert.ToInt32(Console.ReadLine());
int numberTemp = 0;
int numberCopy = number;



if (number < 10000 || number > 99999)
{
    Console.Write("Введено не пятизначное число! Проверьте правильность ввода!");
}

else
{
    while (numberCopy > 0)
    {
        numberTemp = numberTemp * 10 + numberCopy % 10;
        numberCopy /= 10; //numberCopy = numberCopy / 10
    }

    if (number == numberTemp)
    {
        Console.WriteLine(number + " - является палиндромом!");
    }

    else
    {
        Console.WriteLine(number + " - НЕ является палиндромом!");
    }

}*/



/*Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/



/*Console.Clear();
int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = Input("Введите координату x1: ");
int x2 = Input("Введите координату x2: ");
int y1 = Input("Введите координату y1: ");
int y2 = Input("Введите координату y2: ");
int z1 = Input("Введите координату z1: ");
int z2 = Input("Введите координату z2: ");

int lineX = x2 - x1;
int lineY = y2 - y1;
int lineZ = z2 - z1;

Console.WriteLine(Math.Sqrt((lineX * lineX) + (lineY * lineY) + (lineZ * lineZ)));*/



/*Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27.
5 -> 1, 8, 27, 64, 125*/


Console.Clear();

int Cube(int a)
{
    return a * a * a;
}

Console.Write("Введите любое число: ");
int numb = Convert.ToInt32(Console.ReadLine());
int count = 1;
Console.WriteLine(" ");
Console.WriteLine("Таблица кубов введенного числа на интервале от 1 до " + numb + " будет иметь следующий вид:");

while (count < numb)
{
    int cb = Cube(count);
    count++;
    //Console.WriteLine("Таблица кубов числа " + numb + " на интервале от 1 до " + numb);
    Console.Write($"{cb}, ");
}

Console.WriteLine(Cube(numb));

