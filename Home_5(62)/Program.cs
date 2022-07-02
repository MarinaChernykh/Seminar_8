// Заполните спирально массив 4 на 4

void FillArraySpirally(int[,] array)
{
    int size = array.GetLength(0);
    for (int margin = 0; margin < size / 2; margin++)
    {
        for (int i = margin; i < size - margin; i++)
        {
            array[margin, i] = InputNumber();
        }

        for (int i = margin + 1; i < size - margin; i++)
        {
            array[i, size - margin - 1] = InputNumber();
        }

        for (int i = size - margin - 2; i > margin - 1; i--)
        {
            array[size - margin - 1, i] = InputNumber();
        }

        for (int i = size - margin - 2; i > margin; i--)
        {
            array[i, margin] = InputNumber();
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}     ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int InputNumber()
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[,] array = new int[4, 4];
FillArraySpirally(array);
PrintArray(array);
