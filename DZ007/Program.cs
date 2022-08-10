Console.Write("Введите число дня недели: "); 
int num = Convert.ToInt32 (Console.ReadLine());
if (num <= 5) Console.WriteLine("Нет рабочий день");
// Console.WriteLine("Да выходной день");
else if ((num > 5) & (num <=7)) Console.WriteLine("Да выходной день");
else if (num > 7) Console.WriteLine("нет такого дня недели");