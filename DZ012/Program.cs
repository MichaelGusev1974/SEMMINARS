// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
//452 -> 11; 82 -> 10; 9012 -> 12
int SumNumbers(int n)
{
    int sum = 0;
    int result = 0;
    for(int i = 0; n > 0; i++)
    {
        result = n%10;  
        n = n / 10;
        sum = sum + result;  
    }
    return sum;
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumNumbers(num));



