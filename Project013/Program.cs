//  Напишите программу, которая по заданному номеру четверти, показывает диапазон 
//возможных координат точек в этой четверти (x и y).
Console.Clear();
Console.WriteLine("Введите номер четверти ");

int quterNumder = Convert.ToInt32(Console.ReadLine());



if ((quterNumder < 0) || (quterNumder > 4))
{
 Console.WriteLine("Ввели неправильный номер четверти (от 1 до 4)");  
 
}
else if (quterNumder == 1)
{
  Console.WriteLine("Диапазон: x: от 0 до + infinity,  y: от 0 до + infinity");   
}
else if (quterNumder == 2)
{
  Console.WriteLine("Диапазон: x: от - infinity до 0,  y: от 0 до + infinity");    
}
else if (quterNumder == 3)
{
  Console.WriteLine("Диапазон: x: от  - infinity до 0,  y: от  - infinity до 0"); ;   
}
else if (quterNumder == 4)
{
  Console.WriteLine("Диапазон: x: от 0 до + infinity,  y: от  - infinity до 0");  
}
