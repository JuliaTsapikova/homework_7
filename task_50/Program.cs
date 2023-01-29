// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
//в двумерном массиве, и возвращает значение этого элемента или же указание, 
//что такого элемента нет.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//17 -> такого числа в массиве нет

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

int n = GetUserData("Введите количество строк: ");
int m = GetUserData("Введите количество столбцов: ");
int[,] array = Get2DArray(n, m, 0, 99);
Print2DArray(array);
int value1 = GetUserData("Ведите индекс строки: ");
int value2 = GetUserData("Введите индекс столбца: ");
if (value1 > n && value2 > m)
{
    Console.WriteLine($"Такого элемента нет!");
}
    else
    {
        object value3 = array.GetValue(value1,value2);
        Console.WriteLine($"Искомый элемент равен: {value3}");
    }