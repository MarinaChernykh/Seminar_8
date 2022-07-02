// Задайте двумерный массив из целых чисел. Напишите программу, 
// которая удалит строку и столбец, на пересечении которых 
// расположен наименьший элемент массива.

int[,] CreateArray()
{
    Console.Write("Введите кол-во строк: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите кол-во столбцов: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[m, n];
    return array;
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

void ModifyArray (int [,] array)
{
    int min = array [0,0];
    int minI = 0;
    int minJ = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array [i,j] < min)
            {
                min = array [i,j];
                minI = i;
                minJ = j;
            }
        }
    }
    Console.WriteLine($"minI = {minI}, minJ = {minJ}");
    
    int [,] arr = new int [array.GetLength(0)-1, array.GetLength(1)-1];
    int passVertical = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i != minI)
        {
            int passHorizontal = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j != minJ) arr[i-passVertical,j-passHorizontal] = array[i,j];
                else passHorizontal++;
            }
        }
        else passVertical++;
    }
    PrintArray(arr);
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

int[,] array = CreateArray();
FillAray(array);
PrintArray(array);
ModifyArray(array);

