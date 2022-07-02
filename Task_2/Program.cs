// Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы.
// В случае, если это невозможно, программа 
// должна вывести сообщение для пользователя.

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

void ModifyArray(int[,] array)
{
    if (array.GetLength(0) != array.GetLength(1))
    {
        Console.WriteLine("Это невозможно");
    }
    else
    {
        int[,] arr = new int[array.GetLength(0), array.GetLength(1)];
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = array[j, i];
            }
        }
        PrintArray(arr);
    }
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




// int temp = array[0,0];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     int j = 0;
//     for ( j; j < array.GetLength(1); j++)
//     {
//         temp = array[i,j];
//         array[i,j] = array[j,i];
//         array[j,i] = array[i,j];
//     }
//     j = i+1;