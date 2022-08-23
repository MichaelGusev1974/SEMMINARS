//  Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли 
//существовать треугольник со сторонами такой длины.Теорема о неравенстве треугольника: каждая 
//сторона треугольника меньше суммы двух других сторон.

// Console.WriteLine("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число: ");
// int num3 = Convert.ToInt32(Console.ReadLine());
// if ((num1 + num2 > num3) && (num1 + num3 > num2) && (num3 + num2 > num1))
// {
// Console.WriteLine("Треугольник может существовать со сторонами такой длины");
// }
// else Console.WriteLine("Треугольник не может существовать со сторонами такой длины");

void Condition(int a, int b, int c)
{
    if((a + b > c) && (a + c > b) && (c + b > a))
    {
      Console.WriteLine("Треугольник может существовать со сторонами такой длины");  
    }
    else Console.WriteLine("Треугольник не может существовать со сторонами такой длины");
}   
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
Condition(num1, num2, num3);