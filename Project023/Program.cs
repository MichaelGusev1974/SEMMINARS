// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых 
//лежат в отрезке [10,99]. Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
Console.Clear();
int[] arrayRandom = new int[123];
for(int i = 0; i < arrayRandom.Length; i++)
{
    arrayRandom[i] = new Random().Next(1,124);
    Console.Write($"{arrayRandom[i]}  ");  
}
Console.WriteLine();
int count = 0;
for(int i = 0; i < arrayRandom.Length; i++)
if((arrayRandom[i] >= 10) && (arrayRandom[i] <= 99))
count ++;
Console.WriteLine($"Количество элементов в масиве в диапазоне [10, 99]: {count} ");
