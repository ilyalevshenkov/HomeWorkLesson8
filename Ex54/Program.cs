// Задача 54. Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Создаем массив

Console.WriteLine("Задайте количество строк двумерного массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] twoDimArray = new int[m, n];
Random rnd = new Random();
void PrintArray(int[,] matr)
{ for (int i = 0; i < m; i++)
 { for (int j = 0; j < n; j++)
 { Console.Write($"{matr[i, j]} ");}
 Console.WriteLine();}}

void FillArray(int[,] matr)
{ for (int i = 0; i < m; i++)
 { for (int j = 0; j < n; j++)
 { matr[i,j] = Convert.ToInt32(rnd.Next(-100, 100)/10.0);}}}
FillArray(twoDimArray);
Console.WriteLine();
PrintArray(twoDimArray);

// Сортировка созданного массива

Console.WriteLine($"\nОтсортированный массив: ");
OrderArrayLines(twoDimArray);
WriteArray(twoDimArray);

void OrderArrayLines(int[,] twoDimArray)
{
  for (int i = 0; i < twoDimArray.GetLength(0); i++)
  {
    for (int j = 0; j < twoDimArray.GetLength(1); j++)
    {
      for (int k = 0; k < twoDimArray.GetLength(1) - 1; k++)
      {
        if (twoDimArray[i, k] < twoDimArray[i, k + 1])
        {
          int temp = twoDimArray[i, k + 1];
          twoDimArray[i, k + 1] = twoDimArray[i, k];
          twoDimArray[i, k] = temp;
        }
      }
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] twoDimArray)
{
  for (int i = 0; i < twoDimArray.GetLength(0); i++)
  {
    for (int j = 0; j < twoDimArray.GetLength(1); j++)
    {
      twoDimArray[i, j] = new Random().Next();
    }
  }
}

void WriteArray(int[,] twoDimArray)
{
  for (int i = 0; i < twoDimArray.GetLength(0); i++)
  {
    for (int j = 0; j < twoDimArray.GetLength(1); j++)
    {
      Console.Write(twoDimArray[i, j] + " ");
    }
    Console.WriteLine();
  }
};
