// Напишите программу, которая принимает на вход пятизначное число и проверяет, является
//ли оно палиндромом.Например: 14212 -> нет; 12821 -> да; 23432 -> да.
Console.Clear();
Console.WriteLine("Введите пятизначное число:  ");
int num = Convert.ToInt32(Console.ReadLine());
int index = 10000;
bool Check = false;
while(num > 0)
{
    index = num / index;
    num = num % 10;
    
  if(index == num%10)
  {
    Check = true;
  }
   else Check = false;
    index /= 10;
    num /= 10;
}
if(Check)
Console.WriteLine("Число  является палиндромом"); 
else Console.WriteLine("Число   не является палиндромом");