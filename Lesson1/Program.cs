/*//программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
    Console.WriteLine("max=" + num1 + " min=" + num2);
else 
    Console.WriteLine("max=" + num2 + " min=" + num1);*/


//программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num1 > max) max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;

Console.Write("max=" + max);