using System;
using System.Collections.Generic;
namespace cSharpPractice
{
  public class BSTNode
  {
    int val;
    BSTNode left = null;
    BSTNode right = null;

    public BSTNode(int val) 
    {
      this.val = val;
    }

    public BSTNode AddNode(int val) {
      if (this.val == val) throw new ArgumentException("Duplicate values forbidden.");
      if(this.val > val) {
        
        if (this.left != null) return this.left.AddNode((val));
        this.left = new BSTNode(val);
        return this.left;

      } else {
        
        if (this.right != null) return this.right.AddNode(val);
        this.right = new BSTNode(val);
        return this.right;

      }
    }

    public void printTree() {
      List<BSTNode> nodeList = new List<BSTNode>();

      nodeList.Add(this);
      //Performs a level order traversal and prints each value by level.
      while(nodeList.Count > 0) {
        BSTNode currentNode = nodeList[0];
        nodeList.RemoveAt(0);
        if (currentNode.left != null) nodeList.Add(currentNode.left);
        if (currentNode.right != null) nodeList.Add(currentNode.right);
        Console.WriteLine(currentNode.val); 
      }
    }

    public static BSTNode BuildFromSortedArr(int[] arr) {
      if (arr.Length == 0) throw new ArgumentException("Array must not be empty");
      int middle = arr.Length / 2;
      if (middle == 0) return new BSTNode(middle);

      BSTNode root = new BSTNode(arr[middle]);

      BSTNode BuildTreeRecursion(int start, int end) {
        
        int mid = ((end - start) / 2 + start);
        BSTNode childNode = new BSTNode(arr[mid]);
        if (start <= mid - 1) childNode.left = BuildTreeRecursion(start, mid - 1);
        if (mid + 1 <= end) childNode.right = BuildTreeRecursion(mid + 1, end);
        return childNode;

      }

      root.left = BuildTreeRecursion(0, middle - 1);
      root.right = BuildTreeRecursion(middle + 1, arr.Length - 1);
      return root;
    }
  }
}
