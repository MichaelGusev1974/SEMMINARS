int a, b;
Console.WriteLine("Введите первое число: ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.Write("max = ");
    Console.WriteLine(a);
}
else 
{
   Console.Write("max = ");
    Console.WriteLine(b); 
}