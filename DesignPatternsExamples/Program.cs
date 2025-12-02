// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
































int[,] matrix = { { 4, 4, 4, 4 }, 
                  { 1, 4, 4, 4 }, 
                  { 4, 1, 4, 4 }, 
                  { 4, 4, 0, 4 }
                };

var test = SearchMatrix(matrix, 30);

Console.WriteLine(test);

static bool SearchMatrix(int[,] mtx, int target)
{

    int rows = mtx.GetLength(0);
    int cols = mtx.GetLength(1);
    int row = 0, col = 0;

    var valuesConstantArray = new ArrayList
    {
        mtx[row, col]
    };
    while (row < rows && col < cols)
    {
        while (col+1<cols)
        {
            if (valuesConstantArray.Contains(mtx[row+1, col + 1]))
            {
                row++;
                col++;
            }
            //else
            //{
            //    col++;
            //    valuesConstantArray.Add(mtx[row, col]);
            //    break;
            //}
        }

        if (!(col+1<cols)) // finished check all collums 
        {
            col = 0;
            row++;
            valuesConstantArray.Add(mtx[row, col]);
        }

        if ( row+1 >= rows)
        {
            return false; 
        }
    }

    return false; 
}









Console.WriteLine("Hello, World!");
