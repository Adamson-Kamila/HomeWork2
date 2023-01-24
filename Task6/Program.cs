// Напишите программу, которая принимает на вход координаты двух точек и находит
//  расстояние между ними в 3D пространстве.

Console.Clear();

Console.WriteLine("Введите координату X для точки A: ");
int xA = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату Y для точки A: ");
int yA = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату Z для точки A: ");
int zA = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату X для точки B: ");
int xB = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату Y для точки B: ");
int yB = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату Z для точки B: ");
int zB = int.Parse(Console.ReadLine()!);

// result = √(xA-xB)²+(yA-yB)²+(zA-zB)²

double result = Math.Sqrt((Math.Pow((xA - xB),2) + Math.Pow((yA - yB),2) + Math.Pow((zA - zB),2)));

Console.WriteLine($"Расстояние между заданными точками {result:f2}");


