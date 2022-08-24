// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на 
//первом месте, а первый - на последнем и т.д.);[1 2 3 4 5] -> [5 4 3 2 1][6 7 3 6] -> [6 3 7 6]
// Решение 3 
int [] array = {1, 3, 6, 8, 12, 10};
void PrintArray(int []array)// метод вывода на печать заполненного массива
{
int count = array.Length;
for( int i = 0; i < count ; i++)Console.Write($"{array[i]} ");  
}
int [] revers = new int [array.Length];
for(int i = 0; i < array.Length; i++)
{
    revers[i] = array[array.Length -1 -i];
    //Console.Write($"{revers[i]} ");
}
PrintArray(array);
Console.WriteLine();
PrintArray(revers);