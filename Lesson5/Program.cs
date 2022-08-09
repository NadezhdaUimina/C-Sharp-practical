// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] CreateRandomArray(int size, int minValue, int maxValue)  //Рандомный массив
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}


void ShowArray(int[] array)    //Вывод массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write (array[i] + " ");
    }
    Console.WriteLine();
}



int Сounter(int[] array)  // поиск чётных чисел
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) count += 1;
    }
    return count;
}

Console.Write("Введите длину массива: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] binaryArray = CreateRandomArray(number, 100, 999);
ShowArray(binaryArray);
int result = Сounter(binaryArray);
Console.Write($"В данном массиве {result} чётное(-ых) число(-а, -ел) ");



// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


double[] CreateRandomArray(int size, int minValue, int maxValue)  //Рандомный массив
{
    double[] newArray = new double[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}


void ShowArray(double[] array)    //Вывод массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write (array[i] + " ");
    }
    Console.WriteLine();
}

double SumOfElements(double[] array)  // сумма элементов на нечетных позициях
{
    double sum = 0;
    for(int i = 1; i < array.Length; i +=2)
    {
        sum += array[i];
    }
    return sum;
}


Console.Write("Введите длину массива: ");
int number = Convert.ToInt32(Console.ReadLine());
double[] binaryArray = CreateRandomArray(number, -1000, 1000);
ShowArray(binaryArray);
double result = SumOfElements(binaryArray);
Console.Write($"сумму элементов, стоящих на нечётных позициях равна: {result}");


// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


int[] CreateRandomArray(int size, int minValue, int maxValue)  //Рандомный массив
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}


void ShowArray(int[] array)    //Вывод массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write (array[i] + " ");
    }
    Console.WriteLine();
}



int Difference(int[] array)  // поиск чётных чисел
{
    int max = array[0];
    int min = array[0];
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max) max = array[i];
        if(array[i] < min) min = array[i];
    }
    count = max - min;
    return count;
}

Console.Write("Введите длину массива: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] binaryArray = CreateRandomArray(number, 0, 1000);
ShowArray(binaryArray);
int result = Difference(binaryArray);
Console.Write($"Разница между максимальным и минимальным элементом равна:  {result}");
