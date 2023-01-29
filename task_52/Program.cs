// Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

/*Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/


int GetUserData(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int[,] Get2DArray(int rowLength, int colLength, int start, int end)
{
    int[,] array = new int[rowLength, colLength];
    for(int i = 0; i < rowLength; i++)
    {
        for (int j = 0; j < colLength; j++)
        {
            array [i,j] = new Random().Next(start, end + 1 );
        }
    }
    return array;

}

void Print2DArray(int[,] array)
{   
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
        
}

void ColumnAverage(int[,] array)
{  
    for (int i = 0; i < array.GetLength(0); i++)
    {   double sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[j,i];
        }
        double average = Math.Round(sum/array.GetLength(0), 2);
        int column = i + 1;
        Console.WriteLine($"Среднее арифметическое столбца " + column +" равно " + average);
        
    }

}

int n = GetUserData("Введите количество строк: ");
int m = GetUserData("Введите количество столбцов: ");
int[,] array = Get2DArray(n, m, 0, 99);
Print2DArray(array);
ColumnAverage(array);