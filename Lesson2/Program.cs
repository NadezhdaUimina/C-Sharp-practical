/*// программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

int TheSecondDigit (int n)
{
    return (n % 100 / 10);
}

Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вторая цифра данного числа: {TheSecondDigit(num)}");*/


/*//программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

int TheThirdDigit (int n)
{
    if (n > 99) 
    {
        while (n > 1000) 
        {
            n = n / 10;
        }
        n = n % 10;
        Console.Write($"Третья цифра данного числа {n}");
    }
    else Console.Write("Данное число не имеет третьей цифры");
    return n;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
TheThirdDigit(num);*/



//программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

void DayOfTheWeek (int n)
{
    if (n > 0 && n < 6)
    {
        Console.WriteLine("Это рабочий день.");
    }
    else if (n == 6 || n == 7)
    {
        Console.WriteLine("Это выходной день. Урааааа!!!");
    }
    else Console.WriteLine("Такого дня недели не существует.");
}

Console.Write("Введите день недели: ");
int num = Convert.ToInt32(Console.ReadLine());
DayOfTheWeek(num);



