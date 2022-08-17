// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// Например 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]; 6, 1, 33 -> [6, 1, 33]

int[] arrayNew = new int[8];
void FillArray(int[] array)
{
    int length = array.Length;
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(0,100);
        Console.Write($"{array[i]} ");
    }
}
FillArray(arrayNew);
