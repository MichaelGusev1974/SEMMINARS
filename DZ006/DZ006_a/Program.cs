Console.WriteLine("Введите любое число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 0) num = num * -1;
if (num < 100)Console.WriteLine($"у числа {num} третьей цифры нет");
 while (num > 999)
 {
 num = num / 10;
 }
 num = num % 10;


Console.WriteLine(num);