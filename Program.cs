﻿//Задача 1.
//Задайте двумерный массив. Напишите программу, которая поменяет местами две любые строки массива.

/*
int [,] Created2dArray (int rows, int columns, int minV, int maxV)
{
    int [,] createdArray = new int [rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            createdArray[i, j] = new Random().Next(minV, maxV+ 1);
    return createdArray;
}

void ShowArray (int [,] printedarray)
{
    for (int i = 0; i < printedarray.GetLength(0); i++)
    {
        for (int j = 0; j < printedarray.GetLength(1); j++)
        {
            Console.Write(printedarray[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [,] ChangeRows (int [,] arrayToChange, int row1, int row2)
{
    if (row1 >= 0
    && row1 < arrayToChange.GetLength(0)
    && row1 != row2
    && row2 >= 0
    && row2 < arrayToChange.GetLength(0))
    {
        for (int j = 0; j < arrayToChange.GetLength(1); j++)
        {
            int temp = arrayToChange[row1, j];
            arrayToChange[row1, j] = arrayToChange[row2, j];
            arrayToChange[row2, j] = temp;
        }
    }
    else Console.WriteLine("Error! Inpossible input");
    return arrayToChange;
}

Console.Write("Input count of rows: ");
int userRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input count of columns: ");
int userColumns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min number: ");
int userMin = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max number: ");
int userMax = Convert.ToInt32(Console.ReadLine());

int [,] newArray = Created2dArray (userRows, userColumns, userMin, userMax);
ShowArray(newArray);

Console.Write($"Input number of the first row to remove from 0 to {userRows-1}: ");
int userFirstRow = Convert.ToInt32(Console.ReadLine());
Console.Write($"Input number of the second row to remove from 0 to {userRows-1}: ");
int userSecondRow = Convert.ToInt32(Console.ReadLine());

ShowArray(ChangeRows(newArray, userFirstRow, userSecondRow));
*/

// Задача 2.
// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

/*
int [,] Created2DArray (int rows, int columns, int minV, int maxV)
{
    int [,] createdArray = new int [rows, columns];
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                createdArray[i,j] = new Random().Next (minV, maxV+1);
            }
        }
        return createdArray;
    }
}

void ShowArray (int [,] printedArray)
{
    for (int i = 0; i < printedArray.GetLength(0); i++)
        {
            for (int j = 0; j < printedArray.GetLength(1); j++)
            {
                Console.Write (printedArray[i,j] +" ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();   
}

int [,] ChangeRowCols (int [,] arrayToChange)
{
    int temp;
    if (arrayToChange.GetLength(0) == arrayToChange.GetLength(1))

        for (int i = 0; i < arrayToChange.GetLength(0); i++)
            {
                for (int j = i; j < arrayToChange.GetLength(1); j++)
                {
                    temp = arrayToChange[i,j];
                    arrayToChange[i,j] = arrayToChange[j,i];
                    arrayToChange[j,i] = temp;
                }
            }
    else Console.WriteLine (" Error! Impossible values!");
    return arrayToChange;
}

Console.WriteLine("Enter count of rows: ");
int user_rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter count of columns: ");
int user_collumns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Min value: ");
int user_min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Max value: ");
int user_max = Convert.ToInt32(Console.ReadLine());

int [,] array2D = Created2DArray(user_rows, user_collumns, user_min, user_max);
ShowArray(array2D);

int[,] arrayToChange = ChangeRowCols(array2D);
ShowArray(arrayToChange);
*/

// Задача 3.
// Задайте двумерный массив из целых чисел. Напишите программу, которая обнулит строку и столбец, 
// на пересечении которых расположен первый наименьший элемент массива.

