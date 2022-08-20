// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и 
//предпоследний и т.д. Результат запишите в новом массиве. [1 2 3 4 5] -> 5 8 3; [6 7 3 6] -> 36 21
Console.Clear();
int size = 9;
int[]arrayRandom = new int[size];

int[] arrayFill(int sizeOfArray, int x, int y)
{
    for(int i = 0; i < arrayRandom.Length; i++)
    {
    arrayRandom[i] = new Random().Next(x,y+1);
    Console.Write($"{arrayRandom[i]}  ");  
    }
return arrayRandom;
}
Console.WriteLine();
arrayRandom = arrayFill(sizeOfArray: 11, x: 0, y: 200 );

void PrintMultyPairs(int[] array)
{
    for(int i = 0; i < array.Length/2; i++)
    Console.Write($"{array[i]*array[array.Length - i - 1]}  ");
    if(array.Length%2 !=0)
    Console.Write($"{array[array.Length/2]}  ");
}


Console.WriteLine();
PrintMultyPairs(arrayRandom);
