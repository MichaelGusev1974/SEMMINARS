// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным значением элементов массива.
//[3 7 22 2 78] -> 76
Console.Clear();
double[] newarray = new double[10]; //Новый массив из 20 элементов
void FillArray(double[]collection) // Метод, заполняющий массив вещественными числами
{
     for(int i = 0; i < collection.Length; i++)
    { 
    collection[i] = new Random().Next(-10, 10) + Math.Round(new Random().NextDouble() , 1);
    }
}    
void PrintArray(double[] array)   // Метод, выводящий на печать (в консоль) массив, состоящий из вещественных чисел
{
    for(int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]};  ");

    Console.WriteLine();
}
void PrintDifferenceMinMaxElements(double[] array) // Метод, выводящий в консоль значения min и max элементов массива и результат решение задачи
{
    double min =  array[0]; 
    double max =  array[0]; 
    double result = 0;
    for(int i = 0; i < array.Length; i++)
    {                                      
       if(min > array[i]) min = array[i];
       if(max < array[i]) max = array[i];
    }
    result = max - min;
    Console.WriteLine($"Значение минимального элемента: {min} ");
    Console.WriteLine($"Значение максимального элемента: {max} ");
    Console.WriteLine($"Разница между максимальным и минимальным значениями элементов = {result} ");
}
FillArray(newarray);
Console.WriteLine();
 PrintArray(newarray);
 Console.WriteLine();
PrintDifferenceMinMaxElements(newarray);




