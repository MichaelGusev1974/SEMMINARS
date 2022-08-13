// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел 
//от 1 до N. Например: 3 -> 1, 8, 27; 5 -> 1, 8, 27, 64, 125
Console.Clear();
Console.WriteLine("Введите число:  ");
int num = Convert.ToInt32(Console.ReadLine());
int index = 1;
while(index <= num)
{
    Console.Write($"{index*index*index} ");
    index++;
}
Console.WriteLine();