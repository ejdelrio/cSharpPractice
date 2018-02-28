using System;
namespace cSharpPractice;

using System.Runtime.InteropServices;
 
{
  public class LinearMachineLearningAlgorithm
  {

    int[] thetaArr;
    int alpha;
    int[][] data;

    public void ErrorCheck() {
      if (thetaArr.Length == 0) throw new ArgumentException("Class operations require theta values.");
      if (data.Length == 0) throw new ArgumentException("Class operations require data.");
      if (alpha == null) throw new ArgumentException("Class operations require alpha constant.");
    }

    public void setThetas(int [] arr) 
    {
      thetaArr = arr;
    }
    public void setAlpha(int alpha) 
    {
      this.alpha = alpha;
    }
    public int[] getTheta() 
    {
      return thetaArr;
    }
    public int getAlpha()
    {
      return alpha;
    }





  }
}
