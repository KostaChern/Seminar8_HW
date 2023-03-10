// Задача 4 * : Напишите программу, которая заполнит спирально квадратный 
// массив.

Console.Clear();

int [,] GenerateArray(int a, int b)
{
    int[,] array = new int[a, b]; 
        for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i;
        }
    }
    return array;
    

}

void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}\t");
        }
    }
    Console.WriteLine();
}

int [,] Transport (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j < array.GetLength(1); j++)
        {
            (array[i, j],array[j, i]) = (array[j, i], array[i, j]);
        }
    }
    return array;
}

bool Validete(int [,] array)
{
    if (array.GetLength(0) == array.GetLength(1))
    {
        return true;
    }
    return false;
}

int [,] MyArray = GenerateArray(5, 5);
PrintArray(MyArray);
if (Validete(MyArray))
{
    PrintArray(Transport(MyArray));
}