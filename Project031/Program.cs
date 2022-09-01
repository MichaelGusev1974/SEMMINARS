// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
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
int rows = rand.Next(3, 8);
int columns = rand.Next(3, 8);
int[,]array = new int[rows, columns];
int[] bufer = new int[rows];
FillMatrix(array);
PrintMatrix(array);
Console.WriteLine(); 

for(int j = 0; j < array.GetLength(1); j++)
{
    bufer[j] = array[0, j];
    array[0, j] = array[array.GetLength(0) - 1, j];
    array[array.GetLength(0) - 1, j] = bufer[j];
}
PrintMatrix(array);