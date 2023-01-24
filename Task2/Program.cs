// Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет. (Цифры считать справа налево).

Console.Clear();

Console.WriteLine("Введите трёхзначное число");


//int i = int.MinValue && int.MaxValue

int i = new Random().Next(int.MinValue, int.MaxValue);


if ((i / 100) != 0)
{ 
    int ix = (i / 100) % 10;
    Console.WriteLine($"третья цифра числа {i} -> {ix}");
} 
else 
{
    Console.WriteLine($"число {i} не имеет третьего числа");
}

