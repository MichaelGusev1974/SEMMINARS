Console.Write("Введите  число: ");
int a;
a = Convert.ToInt32(Console.ReadLine());
if (a%2 == 0 )
{
    Console.Write(a);
    Console.WriteLine(" - да, число является четным "); 
}
else
{
    Console.Write(a);
    Console.WriteLine(" - нет, число не является четным ");
}