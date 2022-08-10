
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int a = 7;
int b = 23;
if (((num%a) == 0) && ((num%b) ==0))
{
 Console.WriteLine($"Число {num} кратно одновременно числу {a} и числу {b}"); 
}  
else
{
  Console.WriteLine($"Число {num} не кратно одновременно числу {a} и числу {b}");   
}
