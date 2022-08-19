// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на 
//соответствующие отрицательные, и наоборот.
 
int [] array = new int [10];
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-5, 6);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
for(int i = 0; i < array.Length; i++)
{
    array[i] = -array[i];
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
