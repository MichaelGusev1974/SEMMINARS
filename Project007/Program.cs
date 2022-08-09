int num = new Random().Next(10, 100);
Console.WriteLine(num);
int a = num / 10;
int b = num % 10;

int max = a;
if (b > max)
{
    max = b;
}
Console.WriteLine(max);
