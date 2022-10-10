// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце
Console.Clear();

int[,] array = new int[5,5];
double[] average = new double[array.GetLength(1)]; 
FillArray(array);
PrintArray(array);

average = AverageCol(array);
for (int j=0; j<array.GetLength(1); j++)
{
    Console.WriteLine($"The average of column {j} = {average[j]} ");
}

void FillArray(int[,] array)
{
    Random generator = new Random();
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            array[i,j] = generator.Next(0,10);
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

double[] AverageCol(int[,] array)
{
    double[] sum = new double[array.GetLength(1)];
    for (int j=0; j<array.GetLength(1); j++)
    {
        sum[j] = 0;
    }

    for (int j=0; j<array.GetLength(1); j++)
    {
        for (int i=0; i<array.GetLength(0); i++)
        {
            sum[j]+= array[i,j];
        }
        sum[j] = sum[j] / array.GetLength(0);
    }
    return sum;            
}