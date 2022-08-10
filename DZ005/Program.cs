Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if ((num < 99) & (num > -99)) Console.WriteLine( "-это не трехзначное число");
if (num < 0) num = num * -1;
if ((num >= 100) & (num < 1000))
{
num = num % 100;
num = num / 10;
Console.WriteLine(num);
}