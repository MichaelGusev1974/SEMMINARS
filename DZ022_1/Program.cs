// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// Вывел и строки по убыванию и столбцы.
void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
    for(int j = 0; j < array.GetLength(1); j++)
        {
         Console.Write($"{array[i,j]}  ");
        }
       Console.WriteLine();   
    }
} 
void FillArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
   
        for(int j = 0; j < array.GetLength(1); j++)
        {
         array[i,j] = new Random().Next(3,10);
        } 
    }
}
void SelectionSort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(0); k++)
            {
               for(int m = 0; m < array.GetLength(1); m++)
               {
                
                if ((i != k) && (j != m) && (array[i,j] > array[k, m])) //
                    {
                        int temp = array[i, j];
                        array[i, j] = array[k ,m];
                        array[k, m] = temp;
                    }
               }
            }
        }
    }
}
int[,] newArray = new int [5,8];
FillArray(newArray);
PrintArray(newArray);
SelectionSort(newArray);
Console.WriteLine();
PrintArray(newArray);    
