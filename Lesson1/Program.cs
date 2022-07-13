/*//программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

void MaxMinNumber (int num1, int num2)
{
    if(num1 > num2) 
    {
    Console.WriteLine("max=" + num1 + " min=" +num2);
    }
    else Console.WriteLine("max=" + num2 + " min=" + num1);
}

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

MaxMinNumber (number1, number2);*/




/*//программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел

void MaximumNumber (int num1, int num2, int num3)
{
    int max = num1;

    if (num1 > max) max = num1;
    if (num2 > max) max = num2;
    if (num3 > max) max = num3;
    
    Console.Write($"max= {max}");
}

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

MaximumNumber (number1, number2, number3);*/



//программа, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

void AnEvenNumber (int num)
{
    if (num % 2 == 0) Console.Write("число является четным");
    else Console.Write("число является нечетным");
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
AnEvenNumber (number);




/*//программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N


Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = 2;

while (current <= num) 
{
    Console.Write(" " + current);
    current = current + 2;
}*/