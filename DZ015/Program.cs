// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19 ;[-4, -6, 89, 6] -> 0
Console.Clear();
int size = 15;
int[] newarray = new int[size];
void FillArray(int[]collection)
{
     for(int i = 0; i < collection.Length; i++)
    { 
    collection[i] = new Random().Next(-10, 21);
    Console.Write($"{collection[i]} ");
    }
}    
void PrintArray(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 != 0) count+=array[i];
    }
    Console.WriteLine();
    Console.WriteLine($"Сумма не четных чисел равна: {count} ");
}
FillArray(newarray);
Console.WriteLine();
PrintArray(newarray);