// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// Например 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]; 6, 1, 33 -> [6, 1, 33]

int[] arrayNew = new int[8];
int [] FillArray(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(0,10);  
    }
    return array; 
    
}
arrayNew = FillArray(arrayNew);
Console.Write(arrayNew);
