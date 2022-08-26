// **Задача 51:** Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

void PrintArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
    for(int j = 0; j < arr.GetLength(1); j++)
        {
         Console.Write($"{arr[i,j]} ");
        }
       Console.WriteLine();   
    }
} 
void FillArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
   
        for(int j = 0; j < arr.GetLength(1); j++)
        {

         arr[i,j] = new Random().Next(1,10);   
         //if(i%2 == 0 && j%2 == 0)  arr[i,j] = arr[i,j]*arr[i,j];
        } 
    }
   
}
void MultArray(int[,] arr)
{
    int result =0;
    for(int i = 0; i < arr.GetLength(0); i++)
    {
   
        for(int j = 0; j < arr.GetLength(1); j++)
        { 
         if(i == j) result = result + arr[i,j];
        } 
    }
   Console.WriteLine(result);
}

int[,] array = new int [3,4];


FillArray(array);
PrintArray(array);
Console.WriteLine();
MultArray(array);
