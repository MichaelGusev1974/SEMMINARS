// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл 
//пользователь. 0, 7, 8, -2, -2 -> 2;     1,-7, 567, 89, 223-> 3;

 int count = new Random().Next(4, 7);
 Console.WriteLine($"Введите {count} чисел");

 int[]array = new int [count];
 int result =0;
 for(int i = 0; i < count; i++)
 {
     Console.Write($"Введите число: ");
     array[i] = Convert.ToInt32(Console.ReadLine());
     if (array[i] > 0)
     result++;
 }
 Console.WriteLine($"Количество чисел больше нуля: {result}");








