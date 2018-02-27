using System;
namespace cSharpPractice
{
  public class Matrix
  {

    public int[][] body;
    public int dim;

    public Matrix(int dim)
    {
      //Generates a square jagged matrix with random integers
      int[][] matrix = new int[dim][];
      this.dim = dim;
      Random rnd = new Random();

      for (int i = 0; i < dim; i++) {
        int[] innerArr = new int[dim];
        for (int j = 0; j < dim; j++) {
          innerArr[j] = rnd.Next(1, 10);
        }
        matrix[i] = innerArr;
      }
      body = matrix;
    }

    public void printMatrix() {
      
      for (int i = 0; i < dim; i++) {
        for (int j = 0; j < dim; j++) {
          Console.Write(body[i][j] + " ");
        }
        Console.Write("\n");
      }
      Console.WriteLine(("\n--------------"));
    }

    private void flipMatrix()
    {
      //Flips the matrix horizantally
      for (int i = 0, j = dim - 1; i < j; i++, j--)
      {
        int[] innerArr = body[i];
        body[i] = body[j];
        body[j] = innerArr;
      }

    }

    public void rotateMatrix()
    {
      //Rotates the matrix 90 degrees clockwise
      this.flipMatrix();

      for (int i = 0; i < dim; i++)
      {
        for (int j = 0; j < i; j++)
        {
          int val = body[i][j];
          body[i][j] = body[j][i];
          body[j][i] = val;
        }
      }
    }
  }
}
