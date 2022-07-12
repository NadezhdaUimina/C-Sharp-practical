/*// программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

int TheSecondDigit (int n)
{
    return (n % 100 / 10);
}

Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вторая цифра данного числа: {TheSecondDigit(num)}");*/


//программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

int TheThirdDigit (int n)
{
    int number = n / 100 % 10;
    return number;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (TheThirdDigit(num) > 0) Console.WriteLine($"Третья цифра данного числа: {TheThirdDigit(num)}");
    else Console.WriteLine("Третья цифра в данном числе отсутствует");