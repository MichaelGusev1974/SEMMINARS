﻿// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно 
//выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
Console.Clear();
var rand = new Random();
void FillMatrix(int[,,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            for(int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = new Random().Next(10,100);
                int currentNumber = matrix[i, j, k];
                int incomingNumber = 0;
                if(incomingNumber == currentNumber)
                break;
                if(incomingNumber != currentNumber)
                currentNumber = incomingNumber; 
            }
            
        }
    }
}
void PrintMatrix(int[,,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.WriteLine("Page N: "+ (i + 1));
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
           for(int k = 0; k < matrix.GetLength(2); k++)
           {
            Console.Write($"[{matrix[i, j, k]}] = [{i}, {j}, {k}] ");
           } 
            
        }
       Console.WriteLine(); 
    }
}
int x = rand.Next(2, 5);
int y = rand.Next(2, 5);
int z = rand.Next(2, 5);
int[,,] threeDimensionalMatrix = new int [x,y,z]; 
FillMatrix(threeDimensionalMatrix);
PrintMatrix(threeDimensionalMatrix);