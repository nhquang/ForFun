//https://leetcode.com/problems/min-cost-climbing-stairs/


public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        int f1 = cost[0];
        int f2 = cost[1];
        for(int i = 2; i < cost.Length; i++){
            int f = cost[i] + Math.Min(f1,f2);
            f1 = f2;
            f2 = f;
        }
        return Math.Min(f1,f2);
    }
}