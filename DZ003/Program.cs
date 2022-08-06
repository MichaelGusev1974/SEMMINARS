Console.Write("Введите  число: ");
int a;
int n;
a = Convert.ToInt32(Console.ReadLine());
n = a%2;
if (n == 0 )
{
    Console.Write(a);
    Console.WriteLine(" - да, число является четным "); 
}
else
{
    Console.Write(a);
    Console.WriteLine(" - нет, число не является четным ");
}