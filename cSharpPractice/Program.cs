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

      PersonTrieTree contactBook = new PersonTrieTree();
      contactBook.AddContact("Eddie", 7604683448);
      contactBook.AddContact("Eric", 2342342345);
      contactBook.AddContact("Edgar", 6666666666);
      contactBook.AddContact("Sylvia", 6306742391);
      contactBook.AddContact("Emily", 4444444444);
      contactBook.AddContact("Edwin", 4168906994);

      contactBook.displayFuzzySearchresults("E");

    }
  }
}
