//https://leetcode.com/problems/richest-customer-wealth/


public class Solution {
    public int MaximumWealth(int[][] accounts)
    {
        int maxSum = int.MinValue;
        for(int i = 0; i < accounts.Length; i++)
        {
            int sum = 0;
            for(int j = 0; j < accounts[i].Length; j++)
                sum += accounts[i][j];
                
            maxSum = Math.Max(sum, maxSum);
        }
        return maxSum;
    }
}