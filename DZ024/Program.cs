// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.Clear();
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
void ProductMatrix(int[,]matrix1, int[,]matrix2, int[,] matrix3)
{
    if(matrix1.GetLength(0) != matrix2.GetLength(1))
    {
        Console.Write($"Произведение двух матриц с такими размерами невозможно! "); 
    }
    for(int i = 0; i < matrix1.GetLength(0); i++)
    {
        for(int j = 0; j < matrix2.GetLength(1); j++)
        {
          for(int k = 0; k < matrix3.GetLength(0); k++)
          {
            matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
          } 
          //Console.Write($"[{matrix3}] ");  
        }
       Console.WriteLine(); 
    }
}
int rows1 = 2;
int columns1 = 3;
int rows2 = 4;
int columns2 = 2;
int[,] matrix1 = new int[rows1, columns1];
int[,] matrix2 = new int[rows2, columns2];
int[,] product = new int[rows1, columns2];
FillMatrix(matrix1);
PrintMatrix(matrix1);
Console.WriteLine();
FillMatrix(matrix2);
PrintMatrix(matrix2);
Console.WriteLine();
ProductMatrix(matrix1, matrix2, product);
PrintMatrix(product);