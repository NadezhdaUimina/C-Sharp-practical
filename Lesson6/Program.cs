// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.Write("Введите М, длинну маасива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[]array = new double[size];
for(int i = 0; i < size; i++)
{
    Console.Write($"Введите {i+1} элемент из {size}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
for(int i = 0; i < size; i++)
    Console.Write (array[i] + " ");
Console.WriteLine ();
int result = 0;
for(int i = 0; i < size; i++)
    if(array[i] > 0) result +=1;
Console.WriteLine($"В данном числовом ряду {result} числа (-о, -ел) больше 0");


// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

Console.Write("Введите  значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите  значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите  значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите  значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = 0;
double y = 0;
if (k1 == k2 && b1 != b2) Console.Write("данные прямые параллельны");
else if (k1 == k2 && b1 == b2) Console.Write("данные прямые совпадают");
     else {
        x = (b2-b1)/(k1-k2);
        y = k1*x+b1;
        Console.Write($"точка пересечения двух прямых ({x}; {y})");
     }

