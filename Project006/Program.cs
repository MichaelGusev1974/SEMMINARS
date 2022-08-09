int number1 = new Random().Next(100,1000);
Console.WriteLine(number1);
//int number2 = number1 / 100;
//int number3 = number1%10;
//Console.Write(number2);
//Console.WriteLine(number3);
int num = number1 / 100*10 + number1%10;
Console.WriteLine(num);