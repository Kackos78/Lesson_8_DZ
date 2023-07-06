// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

//Метод по созданию неповторяющихся двузначных чисел
void FillMatrixRnd(int[,,] matrix)
{
    Random rnd = new Random();
    int temp = 0;
    int[] check = new int[matrix.GetLength(0) + matrix.GetLength(1) + matrix.GetLength(2)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                for (int l = 0; l < check.Length; l++)
                {
                    temp = rnd.Next(10, 100);
                    for (int o = 0; o < check.Length; o++)
                    {
                        if (check[o] == temp)
                        {
                            temp = rnd.Next(0, 10);
                            o = 0;
                        }
                    }
                    check[l] = temp;
                    matrix[i, j, k] = temp;
                }

            }
        }
    }
    System.Console.WriteLine(string.Join("; ", check));
}


void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                System.Console.Write($"{matrix[i, j, k]} ({i}, {j}, {k}); \t");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}
System.Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите кол-во страниц: ");
int page = Convert.ToInt32(Console.ReadLine());
int[,,] matrix = new int[row, column, page];

FillMatrixRnd(matrix);
PrintMatrix(matrix);