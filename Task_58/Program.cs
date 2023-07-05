// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void FillMatrix(int[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]}; ");
        }
        System.Console.WriteLine();
    }
}

int[,] MultiplicationMatrix(int[,] matrixOne, int[,] matrixTwo)
{
    int[,] matrixMultiplication = new int[matrixOne.GetLength(0), matrixTwo.GetLength(1)];
    if (matrixOne.GetLength(1) != matrixTwo.GetLength(0))
    {
        System.Console.WriteLine("Ошибка ввода данных.");
        return matrixMultiplication;
    }
    
    for (int i = 0; i < matrixMultiplication.GetLength(0); i++)
    {
        for (int j = 0; j < matrixMultiplication.GetLength(1); j++)
        {
            for (int k = 0; k < matrixMultiplication.GetLength(0); k++)
            {
                matrixMultiplication[i, j] += matrixOne[i, k] * matrixTwo[k, j];
            }
           
        }
    
    }
    return matrixMultiplication;
}

System.Console.Write("Первая матрица. Введите кол-во строк: ");
int row1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Первая матрица. Введите кол-во столбцов: ");
int column1 = Convert.ToInt32(Console.ReadLine());
int[,] matrixOne = new int[row1, column1];

System.Console.Write("Вторая матрица. Введите кол-во строк: ");
int row2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Вторая матрица. Введите кол-во столбцов: ");
int column2 = Convert.ToInt32(Console.ReadLine());
int[,] matrixTwo = new int[row2, column2];

FillMatrix(matrixOne);
PrintMatrix(matrixOne);
System.Console.WriteLine();
System.Console.WriteLine();
FillMatrix(matrixTwo);
PrintMatrix(matrixTwo);
System.Console.WriteLine();
System.Console.WriteLine();
PrintMatrix(MultiplicationMatrix(matrixOne, matrixTwo));
