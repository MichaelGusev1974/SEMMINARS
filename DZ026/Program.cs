// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
void SpiralFillMatrix(int m, int n, int[,] matrix)
{
    int value = 01; // Значение, которым будет заполнятся матрица на каждой итерации увеличиваясь на 1.
    // k - индекс начальной строки
    // m - индекс конечной строки
    // l - начальный индекс столбца
    // n - конечный индекс столбца
    int k = 0; int l = 0;
    while(k < m && l < n)
    {
        for (int i = l; i < n; i++)          // Выводим первую строку из оставшихся строк.
        {
            matrix[k, i] = value++;
        }
        k++;
        for (int i = k; i < m; i++)        // Выводим последний столбец из оставшихся столбцов.
        {
            matrix[i, n - 1] = value++;
        }
        n--; 
    
    if(k < m)
        {
            for (int i = n - 1; i >= l; i--) // Выводим последнюю строку из оставшихся строк.
            {
                matrix[m - 1, i] = value++;
            }
            m--;
        }
        
        if(l < n)
        {
            for (int i = m - 1; i >= k; i--) // Выводим первый столбец из оставшихся столбцов.
            {
                matrix[i, l] = value++;
            } 
            l++;
        }
    }    
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"[  {matrix[i, j]}  ]   ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}
int m = 4;
int n = 4;
int rows = m;
int columns = n;
int[,] newMatrix = new int[rows, columns];
SpiralFillMatrix(m, n, newMatrix);
PrintMatrix(newMatrix);