// 70: Напишите программу, которая на вход принимает два числа и выдаёт первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
// 3 и 4, N = 5-> 3 4 7 11 18
// 6 и 10, N = 4-> 6 10 16 26


/*int first = 3;
int second = 4;
int countNum = Input("Введите кол-во N: ");
Console.WriteLine(Fib(first, second, countNum));

string Fib(int first, int second, int countNum)
{
    if (countNum == 0)
    {
        return string.Empty;
    }
    else
    {
        return first + " " + Fib(second, first + second, --countNum);
    }
}


int Input(string output) // дописать дальше метод... иначе работать не будет*/


// ВЕРСИЯ № 2:

/*Console.Write("Введите первое число: ");
int numFirst = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numSecond = int.Parse(Console.ReadLine());
Console.Write("Сколько чисел будем складывать?: ");
int count = int.Parse(Console.ReadLine());

for (int i = 1; i <= count; i++)
{
    Console.Write(Fibonacci(numFirst, numSecond, i) + " ");    
}


int Fibonacci(int a, int b, int count)
{
    if (count == 1) 
        return a;
    if (count == 2) 
        return b;
    else
    {
        int sum = Fibonacci(a, b, count - 1) + Fibonacci(a, b, count - 2);
        return sum;
    }
}*/


// 71: В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита.
// n = 2 -> аа, ии, сс, вв, аи, иа, ис, си, ас, са, 
// ав, ва, ви, ив, св, вс


/*string charsWords = "аисв";
int countCharsInWords = 3;
PrintAllWords(charsWords,countCharsInWords,"");

void PrintAllWords(string alphabet, int length, string prefix)
{
    if (length == 0)
    {
        Console.Write(prefix + " ");
    }
    else
    {
        for (int i = 0; i < alphabet.Length; i++)
        {
            PrintAllWords(alphabet,length-1,prefix + alphabet[i]);
        }
    }
}*/



//72: Заданы 2 массива: info и data. В массиве info хранятся двоичные представления 
// нескольких чисел (без разделителя). В массиве data хранится информация о количестве бит,
// которые занимают числа из массива info. Напишите программу, которая составит массив десятичных
// представлений чисел массива data с учётом информации из массива info.
// входные данные:
// data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
// info = {2, 3, 3, 1 }
// выходные данные:
// 1, 7, 0, 1


/*int[] data = { 1, 0, 1, 1, 1, 0, 0, 0, 1 };
int[] info = { 2, 3, 3, 1 };

int positionData = 0;
for (int i = 0; i < info.Length; i++)
{
    int digit = 0;
    int trueStart = 0;

    int powVal = info[i] - 1;
    for (int j = 0; j < info[i]; j++)
    {
        digit += data[positionData + j] * Convert.ToInt32(Math.Pow(2, powVal-trueStart));
        powVal--;
    }
    Console.Write(digit + " ");

    positionData += info[i];
}*/


// РЕШЕНИЕ ДЕНИСА:


int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = { 2, 3, 3, 1 };

int[] decimalNumbers = GetNumbersFromDataInfo(data, info);

Console.Write("data = ");
PrintArray(data);

Console.Write("info = ");
PrintArray(info);

Console.Write("result = ");
PrintArray(decimalNumbers);


int GetDecimal(int[] bits, int minIdx, int maxIdx)
{
    int number = 0;
    for (int i = minIdx; i < maxIdx + 1; i++)
    {
        number += bits[i] * (int)Math.Pow(2, maxIdx - i);
    }
    return number;
}

int[] GetNumbersFromDataInfo(int[] bits, int[] sizes)
{
    int[] numbers = new int[sizes.Length];

    int startIdx = 0;
    int endIdx = -1;
    for (int i = 0; i < numbers.Length; i++)
    {
        startIdx = endIdx + 1;
        endIdx = endIdx + sizes[i];
        int number = GetDecimal(bits, startIdx, endIdx);
        numbers[i] = number;
    }

    return numbers;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}






