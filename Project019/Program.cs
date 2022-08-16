// Напишите программу, которая принимает на вход число А, и выдает сумму чисел от 1 до А
void SumOneToA(int a)
{
    int sum = 0;
    for(int i = 1; i <= a; i++)
    {
        sum = sum + i;
    }
    Console.WriteLine(sum);
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
SumOneToA(num);







