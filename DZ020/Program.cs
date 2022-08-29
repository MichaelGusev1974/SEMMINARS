// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
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
         array[i,j] = new Random().Next(0,20);
        } 
    }
}
void FindValue(int[,] array, int number1, int number2, int number3)
{
    bool result = false;
    bool count = false;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
         if(i == number1 && j == number2)  Console.WriteLine($"Значение элемента в двумерном массиве по индексам {number1}, {number2} = {array[i,j]}");
         if(i == number1 && j == number2) result = true;
         if(array[i,j] == number3) count = true;
        }
    }
    if(result == true)Console.WriteLine($"В массиве  такие индексы: {number1}, {number2} есть");
    else Console.WriteLine($"В массиве таких индексов:  {number1}, {number2} нет");
    if(count == true)Console.WriteLine($"Число: {number3} есть в этом массиве");
    else Console.WriteLine($"Числа: {number3} нет в этом массиве");
}
Console.Write("Введите индекс строки: ");
int userNumerFirst = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца: ");
int userNumerSecond = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int elementValue = Convert.ToInt32(Console.ReadLine());
int[,] newArray = new int [4,8];
FillArray(newArray);
PrintArray(newArray);
FindValue(newArray, userNumerFirst, userNumerSecond, elementValue);


