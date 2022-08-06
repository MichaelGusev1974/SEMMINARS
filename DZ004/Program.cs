Console.Write("Введите  число: ");
int N;
N = Convert.ToInt32(Console.ReadLine());
while (N > 1)
{
    if (N%2 == 0)
    {
    Console.Write(N);
    Console.Write(" ");
    }
N = N - 1;
}

