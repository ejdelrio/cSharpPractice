using System;

namespace cSharpPractice
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Matrix m = new Matrix(4);
      m.printMatrix();
      m.rotateMatrix();
      m.printMatrix();

      BSTNode root = new BSTNode(6);
      root.printTree();
      int[] sortedArr = new int[] { 2, 3, 4, 5, 6, 7, 8};
      BSTNode treeFromArr = BSTNode.BuildFromSortedArr(sortedArr);
      treeFromArr.printTree();


    }
  }
}
