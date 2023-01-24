// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.

Console.Clear();

 Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine()!);



int a = num / 100 / 100;
int b = num / 100 / 10 % 10;
int c = num / 100 % 10;
int d = num % 100 / 10;
int e = num % 10;

if (a == e) 
{
    if (b == d)
    Console.WriteLine($"Число {num} палиндром. ");
} else 
{
    Console.WriteLine($"Число {num} не является палиндромом. ");
}


