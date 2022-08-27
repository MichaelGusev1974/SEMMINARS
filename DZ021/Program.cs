// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
    for(int j = 0; j < array.GetLength(1); j++)
        {
         Console.Write($"{array[i,j]} ");
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
         array[i,j] = new Random().Next(1,10);   
        } 
    }  
}
void SumColumnArray(int[,] array)
{
    double result1 = 0;
    double result2 = 0;
    double result3 = 0;
    double result4 = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if (i + j == i) result1 = result1 + array[i, j]; 
            if (i + j == i + 1) result2 = result2 + array[i, j];
            if (i + j == i + 2) result3 = result3 + array[i, j];
            if (i + j == i + 3) result4 = result4 + array[i, j];
        } 
    }
   Console.Write($"{result1} {result2} {result3} {result4} сумма элементов в столбцах двумерного массива");
   Console.WriteLine();
   result1 = Math.Round((result1 / 3), 2);
   result2 = Math.Round((result2 / 3), 2);
   result3 = Math.Round((result3 / 3), 2);
   result4 = Math.Round((result4 / 3), 2);
   Console.Write($"{result1} {result2} {result3} {result4} среднее арифметическое элементов столбцов двумерного массива");
}
int[,] newArray = new int [3,4];
FillArray(newArray);
PrintArray(newArray);
Console.WriteLine();
SumColumnArray(newArray);