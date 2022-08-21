// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет 
//количество чётных чисел в массиве. [345, 897, 568, 234] -> 2

Console.Clear();
int size = 20;
int[] newarray = new int[size];
void FillArray(int[]collection)
{
     for(int i = 0; i < collection.Length; i++)
    { 
    collection[i] = new Random().Next(100, 999);
    Console.Write($"{collection[i]} ");
    }
}    
void PrintArray(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) count+=1;
    }

    Console.WriteLine();
    Console.WriteLine($"Количество четных чисел равнo: {count} ");
}
FillArray(newarray);
Console.WriteLine();
PrintArray(newarray);