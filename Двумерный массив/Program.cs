// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
int[,] matrix = new int[rows, columns];
Random rnd = new Random();

for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = rnd.Next(min, max + 1);
}
}
return matrix;
}

void PrintMatrix(int[,] matrix)
{
Console.WriteLine();
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{

Console.Write($"{matrix[i, j],5}");
}
Console.WriteLine();
}
}
Рустам Рустамов @Rustamoff.ru: void ChangeRows(int[,] matrix, int firstRow, int secondRow)
{
// int firstRow = 0;
// int secondRow = matrix.GetLength(0) - 1;
for (int j = 0; j < matrix.GetLength(1); j++)
{
int temp = matrix[firstRow, j];
matrix[firstRow, j] = matrix[secondRow, j];
matrix[secondRow, j] = temp;
// (matrix[secondRow, j], matrix[firstRow, j]) = (matrix[firstRow, j], matrix[secondRow, j]); //вариант с использованием кортежа
}
}

int[,] array2d = CreateMatrixRndInt(5, 4, -100, 100);

PrintMatrix(array2d);
int lastRow = array2d.GetLength(0) - 1;
ChangeRows(array2d, 0, lastRow);
PrintMatrix(array2d);


//-------------------------------
"""
Задача 55: Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы. В случае, если это
невозможно, программа должна вывести сообщение для
пользователя.
"""

void SwapRowsColumns(int[,] matrix)
{
    // for (int i = 1; i < matrix.GetLength(0); i++) // 1-0   2-0   2-1   3-0   3-1   3-2
    for (int i = 0; i < matrix.GetLength(0)-1; i++) // 0-1   0-2   0-3   1-2   1-3   2-3
    {
        // for (int j = 0; j < i; j++)
        for (int j = i + 1; j < matrix.GetLength(1); j++)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
}
bool ValidateSquareMatrix(int[,] matrix)
{
    return matrix.GetLength(0) == matrix.GetLength(1);
}
int[,] array2d = CreateMatrixRndInt(3, 3, 1, 9);
PrintMatrix(array2d);
Console.WriteLine();
if (ValidateSquareMatrix(array2d))
{
    SwapRowsColumns(array2d);
    PrintMatrix(array2d);
}
else Console.WriteLine("Невозможно заменить строки на столбцы.");

//--------------------------
""" 
Задача 57: Составить частотный словарь элементов
двумерного массива. Частотный словарь содержит
информацию о том, сколько раз встречается элемент
входных данных.
"""
int[] MatrixToArray(int[,] matrix)
{
    int[] arr = new int[matrix.Length];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arr[k] = matrix[i, j];
            k++;
        }
    }
    return arr;
}
void FrequencyNumDictionary(int[] arr)
{
    int currentNum = arr[0];
    int count = 1;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] == currentNum) count++;
        else
        {
            Console.WriteLine($"Количество {currentNum} -> {count}.");
            currentNum = arr[i];
            count = 1;
        }
    }
    Console.WriteLine($"Количество {currentNum} -> {count}.");
}
int[,] array2d = CreateMatrixRndInt(3, 3, 1, 9);
PrintMatrix(array2d);
Console.WriteLine();
int[] array = MatrixToArray(array2d);
Array.Sort(array);
int[] arrayTemp = { 1, 1, 1, 2, 2, 2, 3, 3, 3, 9, 9, 9, 9 };
// Console.WriteLine(string.Join(" ", array));
FrequencyNumDictionary(arrayTemp);

//----------------------------

"""
Задача 59: Задайте двумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец, на
пересечении которых расположен наименьший элемент
массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 2 3
4 2 4
2 6 7
"""

