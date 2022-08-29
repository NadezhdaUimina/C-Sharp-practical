// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:              В итоге получается вот такой массив:
// 1 4 7 2                              7 4 2 1
// 5 9 2 3                              9 5 3 2
// 8 4 2 4                              8 4 4 2
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue) // двумерный массив

{
    int[,] newArray = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return newArray;
}

void Show2dArray(int[,] array) // вывод двумерного массива
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
           Console.Write(array[i, j] + " "); 
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] OrderedArray(int[,] array)  // упорядочивание элементов в сроке по убыванию
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1)-1; j++)
        {
            for(int k = 0; k < array.GetLength(1)-1; k++)
            {
                int temp = 0;
                if (array[i,k] < array[i,k+1])
                {
                    temp = array[i,k];
                    array[i,k] = array[i,k+1];
                    array[i,k+1] = temp;
                }
            }
            
        }
    }
    return array;
}

Console.Write("Введите количество строк: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2dArray(num1, num2, 0, 10);
Show2dArray(array);
OrderedArray(array);
Console.WriteLine("Массив с упорядоченными элементами в каждой строке по убыванию:");
Show2dArray(array);
*/



// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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
    
void MinRows (int[,] array)  // нахождение строи с наименьшей суммой элементов
{
    int minSum = Int32.MaxValue;
    int minRows = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];        
        }
        if (sum < minSum)
        {
            minSum = sum;
            minRows = i + 1;
        }
    }
    Console.WriteLine("Cтрока с наименьшей суммой елементов: " + (minRows));
}


Console.Write("Введите количество строк: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2dArray(num1, num2, 0, 10);
MinRows (array);
*/



// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2     и      1 5 8 5
// 5 9 2 3            4 9 4 2
// 8 4 2 4            7 2 2 6
// 5 2 6 7            2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49
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

int[,] Product(int[,] array1, int[,] array2)  // произведение двух матриц
{
    int[,] newArray = new int[array1.GetLength(0), array1.GetLongLength(1)];
    for(int i = 0; i < array1.GetLength(0); i++)
    {
        for(int j = 0; j < array1.GetLength(1); j++)
        {
            newArray[i, j] = array1[i, j] * array2[i, j];
            Console.Write(newArray[i, j] + " ");
        }
        Console.WriteLine();
    }
    return newArray;
}


Console.Write("Введите количество строк: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Первый рандомный массив:");
int[,] array1 = CreateRandom2dArray(num1, num2, 0, 10);
Console.WriteLine("Второй рандомный массив:");
int[,] array2 = CreateRandom2dArray(num1, num2, 0, 10);
Console.WriteLine("Их произведение будет равно следующему массиву:");
Product(array1, array2);
*/



// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)
    
int[,,] CreateRandom3dArray(int num1, int num2, int num3) // трехмерный массив
{  
    int size = num1*num2*num3;
    int[] array = new int[size];
    for (int a = 0; a < array.Length; a++)
    {
        array[a] = new Random().Next(10, 100);
    }
    for (int i = 0; i < array.Length; i++)
    {
        for (int k = i +1; k < array.Length-1; k++)
        {
            if (array[i] == array[k])
            {
                array[i] = new Random().Next(10, 100);
                i = 0;
            }
        }
    }
    
    int[,,] newArray = new int[num1, num2, num3];
    int z = 0;
    for(int i = 0; i < newArray.GetLength(0); i++)
    {
        for(int j = 0; j < newArray.GetLength(1); j++)
            {
                for(int k = 0; k < newArray.GetLength(2); k++)
                {
                    newArray[i, j, k] = array[z];
                    z++;
                }
            }
    }
    return newArray;
}

void Show3dArray(int[,,] array) // вывод трехмерного массива
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
                {
                    Console.Write($"({i}, {j}, {k}){array[i, j, k]} "); 
                }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


Console.Write("Введите размерность 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность 3: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int[,,] array = CreateRandom3dArray(num1, num2, num3);
Show3dArray(array);



// Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7
/*
int[,] Create2dArray(int num)  // создание массива
{
    int[,] newArray = new int[num, num];

    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= newArray.GetLength(0) * newArray.GetLength(1))
    {
        newArray[i, j] = temp;
        if (i <= j + 1 && i + j < newArray.GetLength(0) - 1) j++;
        else if (i < j && i + j >= newArray.GetLength(1) - 1) i++;
        else if (i >= j && i + j > newArray.GetLength(0) - 1) j--;
        else if (i > j && i + j <= newArray.GetLength(1) - 1) i--;
        temp++;
    }
    return newArray;
}

void Print2dArray (int[,] array)  // вывод массива
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}

Console.Write("Введите размерность массива: ");
int num = Convert.ToInt32(Console.ReadLine());

int[,] create2dArray = Create2dArray(num);
Print2dArray(create2dArray);
*/