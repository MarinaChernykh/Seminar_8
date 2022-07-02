// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

int[,] CreateMatrix()
{
    Console.Write("Введите кол-во строк: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите кол-во столбцов: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[m, n];
    return array;
}

bool MultiplicationCheck(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) == matrix2.GetLength(0)) return true;
    else return false;
}

void FillAray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixAB = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixAB.GetLength(0); i++)
    {
        for (int k = 0; k < matrixAB.GetLength(1); k++)
        {
            for (int j = 0; j < matrixAB.GetLength(1); j++)
            {
                matrixAB[i, k] += matrixA[i, j] * matrixB[j, k];
            }
        }
    }
    return matrixAB;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,] matrixA = CreateMatrix();
int[,] matrixB = CreateMatrix();
if (MultiplicationCheck(matrixA, matrixB) == true)
{
    FillAray(matrixA);
    PrintArray(matrixA);
    FillAray(matrixB);
    PrintArray(matrixB);
    int[,] matrixAB = MatrixMultiplication(matrixA, matrixB);
    PrintArray(matrixAB);
}
else Console.WriteLine("Умножение матриц невозможно из-за несоответствия размеров");
