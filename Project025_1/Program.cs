// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на 
//первом месте, а первый - на последнем и т.д.);[1 2 3 4 5] -> [5 4 3 2 1][6 7 3 6] -> [6 3 7 6]
// Решение 2 


void FillArray(int [] array) // метод заполнение массива
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
        //Console.Write($"{array[i]} ");
    }
}

void PrintArray(int []array)// метод вывода на печать заполненного массива
{
int count = array.Length;
for( int i = 0; i < count ; i++)Console.Write($"{array[i]} ");
Console.WriteLine();  
}

void Revers (int [] col)// Разворот путем работы цикла с конца длины массива к 0.
{
    int count = col.Length - 1;
    for(int i = count; i >= 0; i--)Console.Write($"{col[i]} ");  
}

int[] newarray = new int [10];
FillArray(newarray);
PrintArray(newarray);
Revers(newarray);
