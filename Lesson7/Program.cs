// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
/*
double[,] CreateRandom2dArray(int rows, int columns, double minValue, double maxValue) // двумерный массив

{
    double[,] newArray = new double[rows, columns];
    Random random = new Random();
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i, j] = Math.Round(random.NextDouble()*20-10, 2);
            Console.Write(newArray[i, j]);   
            Console.Write(" ");
        }
        Console.WriteLine();
    }
    return newArray;
}

Console.Write("Количество строк m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());


CreateRandom2dArray(m, n, 0, 1);
*/




// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue) // двумерный массив, вывод массива

{
    int[,] newArray = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
            Console.Write(newArray[i, j] + " ");
        }
        Console.WriteLine();
    }
    return newArray;
}

Console.Write("Количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2dArray(m, n, 0, 10);

Console.Write("Введите позицию строки интересующего элемента: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию столбца интересующего элемента: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 < m && num2 < n) 
{
    int result = array[num1, num2];
    Console.WriteLine($"Значение элемента на позиции ({num1}, {num2}) = {result}");
}
else Console.WriteLine ("Элемента с такими данными в массиве нет");
*/




// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue) // двумерный массив, вывод массива

{
    int[,] newArray = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
            Console.Write(newArray[i, j] + " ");
        }
        Console.WriteLine();
    }
    return newArray;
}

void ArithmeticMean(int[,] array)
{
    
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    double arithmeticMean = 0;
    
    Console.Write("Среднее арифметическое каждого столбца: ");
    for(int j = 0; j < rows; j++)
    {
        double sum = 0;
        for(int i = 0; i < columns; i++)
        {
            sum += array[i, j];
        }
        arithmeticMean =  Math.Round(sum / columns, 2);
        Console.Write($"{arithmeticMean} ");
    }
}

Console.Write("Количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2dArray(m, n, 0, 10);
ArithmeticMean(array);

