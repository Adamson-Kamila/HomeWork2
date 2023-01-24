// Напишите программу, которая принимает на вход трёхзначное число
//  и на выходе показывает вторую цифру этого числа.

Console.Clear();

Console.WriteLine("Введите трёхзначное число");

int number = int.Parse(Console.ReadLine()!);

int a = number / 100; //деленние без остатка
int b = number % 100 / 10; //извлекаем вторую цифру
int c = number % 10; //деление с остатком

Console.WriteLine($"вторая цифра числа {number} -> {b}");