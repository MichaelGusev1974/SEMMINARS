// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]; 6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];
void FillArray(int[] array)
{
    int i = 0;
    while(i < array.Length )
    {
    array[i] = new Random().Next(0, 2);
   
    Console.Write($"{array[i]} " );
    i++;
    }
Console.WriteLine();
}
FillArray(array);
