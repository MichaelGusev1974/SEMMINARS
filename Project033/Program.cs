// Задача 57. Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз 
//встречается элемент входных данных.
Console.Clear();
var rand = new Random();

void FillMatrix(int[,] matrix)                            // Метод, заполняющий массив случайными числами
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1,11);
        }
    }
}
void PrintMatrix(int[,] matrix)                          // Ьетод вывода массива на печать
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"[{matrix[i, j]}] ");
        }
       Console.WriteLine(); 
    }
}
bool ValueWasUsed(int number, int[,] matrix)             // Метод, определяющий наличие элемента в массиве
{
bool numExsists = false;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if(number == matrix[i, j])
            {
            numExsists = true;
            break;
            }
        } 
    }
    if(!numExsists) return false;
    else return true;
}
void ShowCountOfRepetions(int number, int[,] matrix)   // Метод, определяющий количество повторений определенного элемента в массиве
{
    int count = 0;
  for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
          if(number == matrix[i, j]) count++; 
        } 
    }
    Console.WriteLine($"Элемент {number} встречается {count} раз"); 
}
int rows = rand.Next(2, 10);
int columns = rand.Next(2, 10);
int[,] array = new int[rows, columns];
FillMatrix(array);
PrintMatrix(array);
Console.WriteLine();

int[,] usedValues = new int [rows, columns];      // Массив для значений элементов, количество которых мы уже посчитали. 
bool valueUsed;
for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            valueUsed = ValueWasUsed(array[i, j], usedValues);
            if(!valueUsed)
            {
              ShowCountOfRepetions(array[i, j], array);
              usedValues[i, j] = array[i, j];  
            }
        }
    }    