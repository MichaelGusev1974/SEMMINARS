//Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагон

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
    for(int i = 0; i < arr.GetLength(0); i++)
    {
   
        for(int j = 0; j < arr.GetLength(1); j++)
        {

            
         if(i%2 == 0 && j%2 == 0)  arr[i,j] = arr[i,j]*arr[i,j];
        } 
    }
   
}

int[,] array = new int [3,4];


FillArray(array);
PrintArray(array);
Console.WriteLine();
MultArray(array);
PrintArray(array);