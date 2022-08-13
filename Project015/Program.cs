Console.Clear();
Console.WriteLine("Введите число:  ");
int num = Convert.ToInt32(Console.ReadLine());
int index = 1;
while(index <= num)
{
    Console.Write($"{index*index} ");
    index++;
}
Console.WriteLine();