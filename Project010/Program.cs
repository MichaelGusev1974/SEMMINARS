Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1*num1 == num2) 
{
  Console.WriteLine($" число {num2} является квадратом {num1}"); 
}  
else if(num2*num2 == num1) 
{
  Console.Write($"число {num1}  является квадратом {num2} ");
}     
else
{
  Console.Write($"число {num1} и {num2} не является квадратами в отношении друг друга");
}