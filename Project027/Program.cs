// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101; 3 -> 11; 2 -> 10;

Console.Write("Введите  число: ");
int n; 
n = Convert.ToInt32(Console.ReadLine());
int n1 = n;
int L = 0;
while (n  >  0)
 {  
    n = n / 2;
    L++;
    //Console.Write(L);
 }
 int [] array = new int [L];
 int i = 0;
 for(int b = 0; i < array.Length; n1/=2)
 {
    b = n1%2;
    array[array.Length - 1 - i] = b;
    i++;
    // Console.Write($"{array[array.Length - 1 - i]}");
 }

void PrintArray(int []array)// метод вывода на печать заполненного массива
{
int count = array.Length;
for( int i = 0; i < count ; i++)Console.Write($"{array[i]} ");  
}
 PrintArray(array);
