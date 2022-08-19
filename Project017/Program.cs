//Напишите программу, которая принимает на вход число N и выдаёт 
//произведение чисел от 1 до N.
//4 -> 24 
//5 -> 120
Console.Clear();
Console.WriteLine("Введите  число:  ");
int num = Convert.ToInt32(Console.ReadLine());
//int MultNumber(int n)
void MultNumber(int n)
{
    int result = 1;
    if(n < 1 ) 
    {
    Console.WriteLine("Ввели неверное число ");
    //return -1;
    }
    else 
    {   
        for(int i = 1;i <= n ; i++)
        {
            result = result*i; 
        }
        //return result;
    Console.WriteLine(result);  
    }
  
}
MultNumber(num);
