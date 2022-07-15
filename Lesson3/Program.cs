// программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом


/*
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
*/



//программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

double Lenth(double xa, double ya, double za, double xb, double yb, double zb)
{
    double lenth = Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2) + Math.Pow((zb - za), 2));
    return lenth;
}
Console.Write("Введите значение координаты Х точки А: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты Y точки А: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты Z точки А: ");
int za = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты Х точки В: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты Y точки В: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты Z точки В: ");
int zb = Convert.ToInt32(Console.ReadLine());
double lenth = Lenth(xa, ya, za, xb, yb, zb);
Console.Write($"Расточние между точками А и В равно {lenth}");