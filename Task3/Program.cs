// Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();

Console.WriteLine("Введите число от 1 до 7: ");

int number = int.Parse(Console.ReadLine()!);

if (number == 1) 
{
    Console.WriteLine("1 -> нет");
}

if (number == 2) 
{
    Console.WriteLine("2 -> нет");
}

if (number == 3) 
{
    Console.WriteLine("3 -> нет");
}

if (number == 4) 
{
    Console.WriteLine("4 -> нет");
}

if (number == 5) 
{
    Console.WriteLine("5 -> нет");
}

if (number == 6) 
{
    Console.WriteLine("6 -> да");
}

if (number == 7) 
{
    Console.WriteLine("7 -> да");
}
if (number > 7 || number < 1)
{
    Console.WriteLine("Неверное число, попробуйте снова. ");
}