// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""
/*
void ShowNums1(int min, int max)  // рекурсия, вывод чисел от наменьшего к наибольшему
{
    if(min != max) ShowNums1(min, max-1);

    Console.Write(max + " ");
}

void ShowNums2(int min, int max)   // рекурсия, вывод чисел от набольшего к наименьшему
{
    Console.Write(max + " ");

    if(min != max) ShowNums2(min, max-1);
}

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 < num2) ShowNums1(num1, num2);
else ShowNums2(num2, num1);
*/



// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
/*
void ShowNums(int min, int max, int sum)  // рекурсия, считающая сумму элементов в отрезке
{
    if(min > max) 
    {
        Console.WriteLine(sum);
        return;
    }
    sum += max;
    ShowNums(min, max-1, sum);
}

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 < num2) ShowNums(num1, num2, 0);
else ShowNums(num2, num1, 0);
*/



// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

int FunctionAkk(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return FunctionAkk(m - 1, 1);
    else return FunctionAkk(m - 1, FunctionAkk(m, n - 1));   
}

Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FunctionAkk(m, n));