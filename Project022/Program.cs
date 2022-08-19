// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//-3; массив [6, 7, 19, 345, 3] -> да

int [] array = new int [10];
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-5, 6);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
Console.WriteLine("Введите число для поиска в массиве: ");
int number = Convert.ToInt32(Console.ReadLine());
bool isNum = false;
for(int i = 0; i < array.Length; i++)
{
    if(number == array[i])
    isNum = true;
}   
Console.WriteLine();
if(isNum == true) Console.WriteLine("Данное число есть в массиве");
else Console.WriteLine("Данного числа нет в массиве");