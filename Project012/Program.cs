// Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
Console.Clear();
Console.WriteLine("Введите координаты точки");
Console.Write("Введите x:   ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите y:   ");
int y = Convert.ToInt32(Console.ReadLine());

if ((x == 0) || (y == 0))
{
 Console.WriteLine("x и y не должны быть равны 0");  
 
}
else if ((x > 0) && (y > 0))
{
  Console.WriteLine("Четверть 1");   
}
else if ((x < 0) && (y > 0))
{
  Console.WriteLine("Четверть 2");   
}
else if ((x < 0) && (y < 0))
{
  Console.WriteLine("Четверть 3");   
}
else if ((x > 0) && (y < 0))
{
  Console.WriteLine("Четверть 4");   
}