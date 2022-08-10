Console.WriteLine("Введите любое число от в диапозоне - 10000 + 10000");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 0) num = num * -1;
if (num < 100)
{
    Console.WriteLine($"у числа {num} третьей цифры нет");
}
if ((num >= 100) & (num < 1000))
{
    Console.WriteLine(num%10);
} 
if ((num >= 1000) & (num < 10000))
{
    num = num / 10;
    Console.WriteLine(num%10);
}    