// Напишите программу, которая принимает на вход число и выдаёт 
//количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5

Console.Clear();
Console.WriteLine("Введите  число:  ");
int num = Convert.ToInt32(Console.ReadLine());
int Count_Number(int n)
{
    int count;
    for (count = 0;n > 0; count++)
    {
        n /= 10;
        
    }
    return count;  
}
Console.WriteLine(Count_Number(num));
