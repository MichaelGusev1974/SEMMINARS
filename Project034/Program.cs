// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"
 string NumbersRec( int a, int n) 
 {
     if(a <= n) 
     return  $"{a} " + NumbersRec(a + 1, n);
      else
      return string.Empty;
 }
 Console.WriteLine("Введите число a ");
 int a = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите число n ");
 int n = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine(NumbersRec(a, n));