// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
Console.Clear();
var rand = new Random();

void FillMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1,11);
        }
    }
}
void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"[{matrix[i, j]}] ");
        }
       Console.WriteLine(); 
    }
}
int rows1 = rand.Next(3, 10);
int columns1 = rand.Next(3, 10);
int rows2 = columns1;
int columns2 = rows1;
int[,] array = new int[rows1, columns1];
int[,] result = new int[rows2, columns2];
FillMatrix(array);
PrintMatrix(array);
Console.WriteLine();
if(rows1 == columns1)
{
  for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
          result[i, j] = array[j, i];  
        } 
    }  
}
else
{
        for(int i = 0; i < array.GetLength(1); i++)
    {
        for(int j = 0; j < array.GetLength(0); j++)
        {
          result[i, j] = array[j, i];  
        } 
    }
}  
PrintMatrix(result);