using System;

namespace cSharpPractice
{
  class MainClass
  {
    public static void Main()
    {
      Matrix m = new Matrix(8);
      m.printMatrix();
      m.rotateMatrix();
      m.printMatrix();

      BSTNode root = new BSTNode(6);
      root.printTree();
      int[] sortedArr = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
      int[] unsortedArr = { 3, 2, 4, 1, 6 };
      BSTNode treeFromArr = BSTNode.BuildFromSortedArr(sortedArr);
      //BSTNode willThrowError = BSTNode.BuildFromSortedArr(unsortedArr);
      treeFromArr.printTree();

      PersonTrieTree contactBook = new PersonTrieTree();

      contactBook.AddContact("Eddie", 7604683448);
      contactBook.AddContact("Eric", 2342342345);
      contactBook.AddContact("Edgar", 6666666666);
      contactBook.AddContact("Sylvia", 6306742391);
      contactBook.AddContact("Emily", 4444444444);
      contactBook.AddContact("Edwin", 4168906994);
      contactBook.AddContact("Sean", 9999999999);

      contactBook.displayFuzzySearchresults("Ed");
      Console.WriteLine("\n--------\n");
      contactBook.displayFuzzySearchresults("S");
      Console.WriteLine("\n--------\n");
      contactBook.displayFuzzySearchresults("Se");

      //Practie with enumerators :D
      var firstEnumVal = firstEnum.first;
      var fifthEnumVal = firstEnum.fifth;
      Console.WriteLine((int) firstEnumVal);

      Console.WriteLine(fifthEnumVal);
      Console.WriteLine((int)fifthEnumVal);

      //Console.practice
      Console.WriteLine("Please Enter your name :D");
      string name = Console.ReadLine();
      Console.WriteLine(string.Format("Hello {0}!!!! Nice to meet you", name));
  
    }
  }
  enum firstEnum
  {
    first,
    secnod,
    fifth = 5,
    tenth = 10
  };

}
