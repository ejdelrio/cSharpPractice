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
      Console.WriteLine("-------------");

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

      BSTNode BuildTreeRecursion(int start, int end) {
        int range = end - start;
        int rounder = range % 2 != 0 ? 1 : 0;
        int mid = (range / 2 + start) + rounder;
    
        BSTNode childNode = new BSTNode(arr[mid]);
        if (start <= mid - 1) childNode.left = BuildTreeRecursion(start, mid - 1);
        if (mid + 1 <= end) childNode.right = BuildTreeRecursion(mid + 1, end);
        return childNode;

      }


      return BuildTreeRecursion(0, arr.Length - 1);
    }
  }
}
