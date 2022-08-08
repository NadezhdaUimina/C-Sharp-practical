// цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*
int Exponentiation (int numA, int numB)
{
    int i = 1;
    int result = 1;
    while (i <= numB)
    {
        result *= numA;
        i++;
    }
    return result;
}

Console.Write("Введите число A ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В ");
int numberB = Convert.ToInt32(Console.ReadLine());
int еxponentiation = Exponentiation (numberA, numberB);
Console.WriteLine($"Число {numberA} возведенное в степень {numberB} равно {еxponentiation}");
*/


// программа, которая принимает на вход число и выдаёт сумму цифр в числе.

/*
int SumOfNumbers(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}

Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int sumOfNumbers = SumOfNumbers(number);
Console.WriteLine("сумма цифр в числе равна " + sumOfNumbers);
*/


// программа, которая задаёт массив из 8 элементов и выводит их на экран.

void CreateRandomArray(int[] array)
{
    int length = array.Length;
    int i = 0;
    while (i < length)
    {
        array[i] = new Random().Next();
        i++;
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write (arr[i] + ", ");
    }
    Console.WriteLine();
}


int [] newArray = new int [8];
CreateRandomArray(newArray);
PrintArray(newArray);
