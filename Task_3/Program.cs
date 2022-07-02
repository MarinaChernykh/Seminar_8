// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных.

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

int [] TransformArray (int [,] array)
{
    int [] arr = new int [array.Length];
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arr[count] = array [i,j];
            count++;
        }
    }
    return arr;
} 

int [] SortArray (int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        int minPosition = i;
        for (int j = i+1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array [i] = array [minPosition];
        array [minPosition] = temporary;
    }
    return array;
}

void Counter (int[] array)
{
    int count = 1;
    int number = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array [i] == array [i-1]) count ++;
        else 
        {
            Console.WriteLine ($"Число {number} встречается {count} раз");
            count = 1;
            number = array[i];
        }
    }
}

void Print2DArray(int[,] array)
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

void Print1DArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[,] array = CreateArray();
FillAray(array);
Print2DArray(array);
int [] MonoArray = TransformArray(array);
Print1DArray(MonoArray);
MonoArray = SortArray(MonoArray);
Print1DArray(MonoArray);
Counter (MonoArray);


