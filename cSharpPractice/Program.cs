using System;
using System.Security;

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
      Console.WriteLine((int)firstEnumVal);

      Console.WriteLine(fifthEnumVal);
      Console.WriteLine((int)fifthEnumVal);

      //Practice with variable number of  arguments :D
      variableNumberOfArguments(5, "Bacon", "Turtle", "Donkey");

      //Practice witgh default parameters :D

      int toTheFirst = defaultParamterExample(5);
      int toTheThird = defaultParamterExample(5, 3);

      Console.WriteLine(toTheFirst);
      Console.WriteLine(toTheThird);

      //Practice with multi-dimensional arrays

      int[,,] multiDimArray = new int[3, 4, 2];
      int dims = multiDimArray.Rank;
      for (int i = 0; i < dims; i++)
      {
        Console.WriteLine(multiDimArray.GetLength(i));
      }

      //Callback example :D;
      Console.WriteLine();
      Console.WriteLine(callBackExample(5, 3, (a, b) => a + b));
      Console.WriteLine(callBackExample(5, 3, (a, b) => a * b));
      Console.WriteLine(callBackExample(5, 3, (a, b) => a - b));





    }
    public static void variableNumberOfArguments(int num, params string[] args)
    {
      for (int i = 0; i < args.Length; i++)
      {
        Console.WriteLine(args[i]);
      }
    }

    public static int defaultParamterExample(int num, int pow = 1)
    {
      return (int)Math.Pow(num, pow);
    }

    public delegate int CallBack(int a, int b);

    public static int callBackExample(int a, int b, CallBack cb) {
      return cb(a, b);
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
