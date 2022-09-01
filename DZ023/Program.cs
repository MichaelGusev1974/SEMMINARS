// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
Console.Clear();
var rand = new Random();
void PrintOneArray(int[] array)  // метод вывода на печать заполненного щдноьерного массива
{
int count = array.Length;
for( int i = 0; i < count ; i++)
    {
    Console.WriteLine($"Сумма элементов строки {i}: {array[i]} ");  
    }
}
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
int[] SumElementOfRows(int[,] array)
{  
    int [] arraySumElementsRows = new int[array.GetLength(0)];
    for(int i = 0; i < array.GetLength(0); i++)
    {
         int SumElementsRows = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {  
            arraySumElementsRows[i] += array[i,j]; 
            SumElementsRows += array[i,j]; 
        }
        //Console.WriteLine($"Сумма элементов строки {i}: {SumElementsRows} ");  
    } 
    return arraySumElementsRows;  
}
 void MinSumRows(int[] array)
{
    int index = 0;
    int min = array[0];
    for( int i = 1; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
            index = i; 
        }      
    }
    Console.WriteLine($"Наименьшая сумма элементов в строке {index} = {min} "); 
}   


int rows = rand.Next(4, 8);
 int columns = rand.Next(4, 10);
int[,] newArray = new int [rows,columns];
FillArray(newArray);
PrintArray(newArray);
Console.WriteLine();
SumElementOfRows(newArray);
int[]array = SumElementOfRows(newArray);
PrintOneArray(array);
MinSumRows(array);
 
 