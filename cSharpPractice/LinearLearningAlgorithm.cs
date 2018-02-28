using System;
namespace cSharpPractice
{
  public class LinearLearningAlgorithm
  {

    int[] theta;
    int[][] data;
    int alpha;

    public void SetTheta(int[] arr) 
    {
      theta = arr;
    }

    public int[] GetTheta() {
      return theta;
    }

    public void SetAlpha (int val) 
    {
      alpha = val;
    }

    public int GetAlpha() 
    {
      return alpha;
    }

    int Hypothesis(int[] row) 
    {
      int sum = theta[0];

      for (int i = 1; i < theta.Length; i++) 
      {
        int thetaVal = theta[i];
        int xVal = row[i - 1];
        sum += thetaVal * xVal;
      }
      return sum;
    }
    int CalculateDeviation(int[] row) 
    {
      int yValActual = row[row.Length - 1];
      int yValHypothetical = Hypothesis(row);
      return yValHypothetical - yValActual;
    }

    int CostFunction(int[] row) 
    {
      
      int dataSize = data.Length;
      int deviation = CalculateDeviation(row);

      return (deviation ^ 2) / (2 * dataSize);
    }

    int DerivedCostFunction(int ind, int[] row) 
    {
      int dataSize = data.Length;
      int outerXVal = ind == 0 ? 1 : row[ind - 1];
      int deviation = CalculateDeviation(row);
      return (outerXVal * deviation) / dataSize;
    }
  }
}
