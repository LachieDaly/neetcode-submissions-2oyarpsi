public class Solution {
    public int MinCostClimbingStairs(int[] cost) 
    {
        int[] costToTop = new int[cost.Length];
        costToTop[cost.Length - 1] = cost[cost.Length - 1];
        costToTop[cost.Length - 2] = cost[cost.Length - 2];
        for (int i = cost.Length - 3; i >= 0; i--) 
        {
            costToTop[i] = cost[i] + Math.Min(costToTop[i+1], costToTop[i+2]);
        }
        // foreach (int costa in costToTop) 
        // {
        //     Console.WriteLine(costa);
        // }

        return Math.Min(costToTop[0], costToTop[1]);
    }
}
