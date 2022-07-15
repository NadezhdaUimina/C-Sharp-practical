// программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом


int Palindrome(int num)
{
    int theTeverseresult = 0;
    while (num > 0){
        theTeverseresult = theTeverseresult * 10 + num % 10;
        num = num / 10;
    }
    return theTeverseresult;
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == Palindrome(number)) {
    Console.WriteLine("Данное число является палиндромом");
}
else Console.WriteLine("Данное число не является палиндромом");

