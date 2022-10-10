// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.Clear();
Console.Write("Type row-index of the array: ");
int elRow = int.Parse(Console.ReadLine()!);
Console.Write("Type column-index of the array: ");
int elCol = int.Parse(Console.ReadLine()!);

int[,] array = new int[5,5];
FillArray(array);
PrintArray(array);
Console.WriteLine("");

if (elRow <= array.GetLength(0) && elCol <= array.GetLength(1))
    Console.WriteLine($"The value of the element {elRow},{elCol} is {ElinArray(array)} in the array");
else
{
    Console.WriteLine($"The element {elRow},{elCol} doesn't exist in the array");
}

void FillArray(int[,] array)
{
    Random generator = new Random();
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            array[i,j] = generator.Next(0,100);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine("");
    }
}

int ElinArray(int[,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
        for (int j=0; j<array.GetLength(1); j++)
            if(i==elRow && j==elCol)
            {
                return array[i,j];
                break;
            }
    return 0;            
}

