Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1%num2 == 0)
{
  Console.Write(num2);
  Console.WriteLine(" число кратное"); 
}  
else
{
    Console.Write("Остаток: ");
    Console.Write(num1%num2);
    Console.WriteLine(" число не кратное"); 
} 
