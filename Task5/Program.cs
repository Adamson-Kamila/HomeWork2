// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

int count = 1;
Console.Write($"{Math.Pow(count,3)}");
count++;
while(count < number+1) 
{
   double result = Math.Pow(count,3);
   Console.Write($", {result}");
   count++;
}