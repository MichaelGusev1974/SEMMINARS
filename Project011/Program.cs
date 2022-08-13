// Вводим многозначное число.Необходимо узнать и сказать последовательность цифр этого 
//числа при просмотре слева направо упорядочена по возрастанию или нет.
//Например 1579 - да, 1427 - нет
Console.Clear();
Console.WriteLine("Введите число:  ");
int num = Convert.ToInt32(Console.ReadLine());
int index = 10;
bool Check = false;
while(num > 0)
{
  if(index > num%10)
  {
    Check = true;
  }
   else Check = false;
    index = num%10;
    num/=10;
}
if(Check)
Console.WriteLine("Число  упорядочено"); 
else Console.WriteLine("Число   не упорядочено");