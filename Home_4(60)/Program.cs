// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.


int[,,] Create3Darray()
{
    Console.Write("Введите 1 размерность трехмерного массива: ");
    int l = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите 2 размерность трехмерного массива: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите 3 размерность трехмерного массива: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[,,] array = new int[l, m, n];
    return array;
}

int GenerateUniqueNumber(int[,,] array)
{
    bool check = false;
    int number = 0;
    number = new Random().Next(10, 100);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == number)
                {
                    check = true;
                    break;
                }
            }
        }
    }
    if (check == true) return GenerateUniqueNumber (array);
    else return number;
}

void Fill3DAray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = GenerateUniqueNumber (array);
            }
        }
    }
}

void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i}, {j}, {k})  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}



int[,,] array = Create3Darray();
Fill3DAray(array);
Print3DArray(array);



