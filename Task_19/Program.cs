// // Задача 19: Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.

Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int temp1 = num;

int firstDigit = NewMethod(ref temp1);

int secondDigit = NewMethod1(ref temp1);

int fourthDigit = NewMethod2(ref temp1);

int fifthDigit = temp1;

if (firstDigit == fifthDigit && secondDigit == fourthDigit)
{
    Console.Write("Это палиндром!");
}
else
{
    Console.Write("Это не палиндром!");
}

static int NewMethod(ref int temp1)
{
    int firstDigit = temp1 / 10000;
    temp1 = temp1 % 10000;
    return firstDigit;
}

static int NewMethod1(ref int temp1)
{
    int secondDigit = temp1 / 1000;
    temp1 = temp1 % 1000;

    temp1 = temp1 % 100;
    return secondDigit;
}

static int NewMethod2(ref int temp1)
{
    int fourthDigit = temp1 / 10;
    temp1 = temp1 % 10;
    return fourthDigit;
}
