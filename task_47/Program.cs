// Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.

//m = 3, n = 4.

//0,5 7 -2 -0,2

//1 -3,3 8 -9,9

//8 7,8 -7,1 9

int GetUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

void PrintInColor(string data)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write(data);
    Console.ResetColor(); 
}

double[,] GetDouble2DArray(int rowLength, int colLength, int start, int end)
{
    double[,] array = new double[rowLength, colLength];
    int divider = 100;
    for(int i = 0; i < rowLength; i++)
    {
        for (int j = 0; j < colLength; j++)
        {
            array [i,j] = new Random().Next(start * divider, end + 1 * divider) / (divider + 0.0);
        }
    }
    return array;

}

void PrintDouble2DArray(double[,] array)
{   
    Console.Write(" \t");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        PrintInColor(j + "\t");
    }
    Console.WriteLine();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        PrintInColor(i + "\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
        
}


int n = GetUserData("Введите количество строк: ");
int m = GetUserData("Введите количество столбцов: ");
double[,] array = GetDouble2DArray(n, m, 0, 100);
PrintDouble2DArray(array);