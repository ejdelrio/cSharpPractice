using System;
using System.Collections.Generic;
namespace cSharpPractice
{
  public class LinearLearningAlgorithm
  {

    int[] theta;
    List<int[]> data = new List<int[]>();
    int alpha;
    int lambda;


    public List<int[]> AddDataRow(int [] row) {
      data.Add(row);
      return data;
    }

    public void SetTheta(int[] arr) 
    {
      theta = arr;
    }

    public int[] GetTheta() {
      return theta;
    }

    public void SetLambda(int val)
    {
      lambda = val;
    }

    public int GetLambda() {
      return lambda;
    }

    public int Regularization() {
      return 5;
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

    int CalculateDeviation(int[] row) {
      int yActual = row[row.Length - 1];
      int yHypothetical = Hypothesis(row);
      return (yActual - yHypothetical) ^ 2;
    }

    int CalculateDeviationSum() {
      int sum = 0;

      for (int i = 0; i < data.Count; i++) {
        int[] row = data[i];
        sum += CalculateDeviation(row);
      }
      return sum;
    }

    int CalculateDerivedDeveation(int ind, int [] row) {
      int outerXVal = ind == 0 ? 1 : row[ind - 1];
      int yActual = row[row.Length - 1];
      int yHypothetical = Hypothesis(row);
      return (yActual - yHypothetical) * outerXVal;
    }

    int CalculateDerivedDeveationSum(int ind) {
      int sum = 0;

      for (int i = 0; i < data.Count; i++)
      {
        int[] row = data[i];
        sum += CalculateDerivedDeveation(ind, row);
      }
      return sum;
    }

    int CalculateCost(int ind) {
      int m = data.Count;
      int TotalError = CalculateDeviationSum();
      return TotalError / (ind * m);
    }

    int SingleGradientStep(int ind) {
      int thetaVal = theta[ind];
      int cost = CalculateCost(1);
      return thetaVal - alpha * cost;
    }
   
  }
}
