using System;

namespace cSharpPractice
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      Matrix m = new Matrix(4);
      m.printMatrix();
      m.rotateMatrix();
      m.printMatrix();


    }
  }
}
