Console.WriteLine("Приветствую Вас");
int a, b;
Console.WriteLine("Введите первое число: ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
b = Convert.ToInt32(Console.ReadLine());
if (a == b * b)
{
    Console.WriteLine("Первое, указанное Вами число является квадратом второго");
}
else
{
    Console.WriteLine("Первое, указанное Вами число не является квадратом второго");
}
    
