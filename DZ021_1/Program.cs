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
    int n = array.GetLength(0);
    int m = array.GetLength(1);   
    for( int i = 0; i < m; i++)
    {
       double sumColumn = 0;
       double arithmeticMeanColumn = 0;
        for( int j = 0; j < n; j++)
        {  
            sumColumn += array[j,i];
            arithmeticMeanColumn = Math.Round((sumColumn / n), 2);
        } 
       Console.WriteLine($"Сумма элементов стобца {i}: {sumColumn} "); 
       Console.WriteLine($"Среднее арифметическое стобца {i}: {arithmeticMeanColumn} "); 
    } 
}
int[,] newArray = new int [3,4];
FillArray(newArray);
PrintArray(newArray);
Console.WriteLine();
SumColumnArray(newArray);