int DayWeek;
Console.Write("Введите число дня недели: "); 
DayWeek = Convert.ToInt32 (Console.ReadLine());
if (DayWeek == 1)
{
    Console.WriteLine("Понедельник");      
}
if (DayWeek == 2)
{
   Console.WriteLine("Вторник"); 
}
if (DayWeek == 3)
{
   Console.WriteLine("Среда"); 
}
if (DayWeek == 4)
{
   Console.WriteLine("Четверг"); 
}
if (DayWeek == 5)
{
   Console.WriteLine("Пятница"); 
}
if (DayWeek == 6)
{
   Console.WriteLine("Суббота"); 
}
if (DayWeek == 7)
{
   Console.WriteLine("Воскресенье"); 
}