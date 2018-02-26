using System;
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
  }
}
