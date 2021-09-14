/*Write a function that accepts a square matrix (N x N 2D array) and returns the determinant of the matrix.

How to take the determinant of a matrix -- it is simplest to start with the smallest cases:

A 1x1 matrix |a| has determinant a.

A 2x2 matrix [ [a, b], [c, d] ] or

|a  b|
|c  d|
has determinant: a*d - b*c.

The determinant of an n x n sized matrix is calculated by reducing the problem to the calculation of the determinants of n matrices ofn-1 x n-1 size.

For the 3x3 case, [ [a, b, c], [d, e, f], [g, h, i] ] or

|a b c|  
|d e f|  
|g h i|  
the determinant is: a * det(a_minor) - b * det(b_minor) + c * det(c_minor) where det(a_minor) refers to taking the determinant of the 2x2 matrix created by crossing out the row and column in which the element a occurs:

|- - -|
|- e f|
|- h i|  
Note the alternation of signs.

The determinant of larger matrices are calculated analogously, e.g. if M is a 4x4 matrix with first row [a, b, c, d], then:

det(M) = a * det(a_minor) - b * det(b_minor) + c * det(c_minor) - d * det(d_minor)*/

using System;

public class Matrix
{
   public static int Determinant(int[][] matrix)
   {
     int numRows = matrix.Length;
     int numColumns = matrix[0].Length;
     
     if (numRows != numColumns)
       throw new ArgumentException("You must pass an N x N array");
    
     if (numRows == 1 && numColumns == 1)
       return matrix[0][0];
     
     if (numRows == 2 && numColumns == 2)
       return matrix[0][0] * matrix[1][1] - matrix[0][1] * matrix[1][0];
     
     int result = 0;
     
     for (int col = 0; col < numColumns; col++)
     {
       if (col % 2 == 0)
         result += matrix[0][col] * Determinant(GetMinorMatrix(0, col, matrix));
       else
         result -= matrix[0][col] * Determinant(GetMinorMatrix(0, col, matrix));
     }
     
     return result;
   }
  
  private static int [][] GetMinorMatrix(int row, int col, int[][] matrix)
  {
    int numRows = matrix.Length;
    int numColumns = matrix[0].Length;
    int[][] minor = new int[numRows - 1][];
    int rowIndex = 0;
    
    for (int i = 0; i < numRows; i++)
    {
      if (i == row)
        continue;
      
      minor[rowIndex] = new int[numColumns - 1];
      int colIndex = 0;
      
      for (int j = 0; j < numColumns; j++)
      {
        if (j == col)
          continue;
        
        minor[rowIndex][colIndex++] = matrix[i][j];
      }
      
      rowIndex++;
    }
    
    return minor;
  }
  
  private static void PrintMatrix(int[][] matrix)
  {
    int numRows = matrix.Length;
    
    for (int i = 0; i < numRows; i++)
    {
      int[] row = matrix[i];
      string rowVals = $"Row {i}: ";
      
      foreach (int n in row)
        rowVals += "{n}. ";
      
      Console.WriteLine(rowVals);
    }
  }
}