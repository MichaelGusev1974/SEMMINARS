// Напишите программу, которая принимает на вход координаты двух точек и находит 
//расстояние между ними в 3D пространстве.Например A (3,6,8); B (2,1,-7), -> 15.84; 
//A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();
Console.WriteLine("Введите координаты первой точки А:  ");
Console.Write("Введите x:  ");
int Ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y:  ");
int Ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z:  ");
int Az = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки B:  ");
Console.Write("Введите x:  ");
int Bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y:  ");
int By = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z:  ");
int Bz = Convert.ToInt32(Console.ReadLine());

double distans = Math.Sqrt(Math.Pow((Ax - Bx),2) + Math.Pow((Ay - By),2) 
+ Math.Pow((Az - Bz),2));

distans = Math.Round(distans,2);
Console.WriteLine (distans);
