// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
Console.Clear();
var rand = new Random();
void PrintArray(int[,] array)                     // Метод вывода на печать двумерного массива
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
void FillArray(int[,] array)                      // Метод заполнения двумерного массива случайными целыми числами в заданном диапазоне.
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
   
        for(int j = 0; j < array.GetLength(1); j++)
        {
         array[i,j] = new Random().Next(1,10);
        } 
    }
}
void SelectionSort(int[,] array)                // Метод сортировки строк двумерного массива по убыванию
{
    for(int i = 0; i < array.GetLength(0); i++) 
    {
        for(int j = 0; j < array.GetLength(1) - 1; j++)
        {
            int maxValue = j;
            for(int k = j + 1; k < array.GetLength(1) ; k++)
            {
                if(array[i, k] > array[i, maxValue])
                {
                    maxValue = k;
                }
            }
            if(maxValue != j)
            {
                int temp = array[i, j];
                array[i, j] = array[i, maxValue];
                array[i, maxValue] = temp;
            }
        }   
    }  
}
 int rows = rand.Next(4, 8);
 int columns = rand.Next(4, 10);
int[,] newArray = new int [rows, columns];
FillArray(newArray);
PrintArray(newArray);
Console.WriteLine();
SelectionSort(newArray);
PrintArray(newArray);







