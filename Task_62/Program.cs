// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07



void FillMatrixSpiral(int[,] matrix, int row, int colomn)
{
    int minRow = 0;
    int maxRow = row - 1;
    int minCol = 0;
    int maxCol = colomn - 1;
    int count = 1;
    int max = row * colomn;
    while (count < max)
    {
        for (int i = minCol; i <= maxCol; i++)
        {
            matrix[minRow, i] = count;
            count++;
        }
        minRow = minRow + 1;
        for (int i = minRow; i <= maxRow; i++)
        {
            matrix[i, maxCol] = count;
            count++;
        }
        maxCol = maxCol - 1;
        for (int i = maxCol; i >= minCol; i--)
        {
            matrix[maxRow, i] = count;
            count++;
        }
        maxRow = maxRow - 1;
        for (int i = maxRow; i >= minRow; i--)
        {
            matrix[i, minCol] = count;
            count++;
        }
        minCol = minCol + 1;
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} \t");
        }
        System.Console.WriteLine();
    }
}

System.Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[row, column];

FillMatrixSpiral(matrix, row, column);
PrintMatrix(matrix);
