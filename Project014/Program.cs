// Напишите программу, которая принимает на вход координаты двух точек и находит 
//расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21
Console.Clear();
Console.WriteLine("Введите координаты первой точки А:  ");
Console.WriteLine("Введите x:  ");
int Ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y:  ");
int Ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки B:  ");
Console.WriteLine("Введите x:  ");
int Bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y:  ");
int By = Convert.ToInt32(Console.ReadLine());

double distans = Math.Sqrt(Math.Pow((Ax - Bx),2) + Math.Pow((Ay - By),2));
distans = Math.Round(distans,2);
Console.WriteLine(distans);