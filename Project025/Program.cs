// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на 
//первом месте, а первый - на последнем и т.д.);[1 2 3 4 5] -> [5 4 3 2 1][6 7 3 6] -> [6 3 7 6]


void FillArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void Revers (int [] collection)
{
    int count = collection.Length;
    int temp = collection[0];
 for(int i = 0; i < count/2 ; i++)
 {
    temp = collection [i];
    collection[i] = collection[count -1 - i];
    collection[count - 1 - i] = temp;
 }   
 for( int i = 0; i < count ; i++)Console.Write($"{collection[i]} ");
 Console.WriteLine();
}
int[] array = new int [10];
FillArray(array);
Revers(array);


