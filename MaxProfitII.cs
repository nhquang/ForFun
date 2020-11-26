//https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/



public class Solution {
    public int MaxProfit(int[] prices) {
        int max = 0;
        for(int i = 0; i < prices.Length - 1; i++){
            if(prices[i] < prices[i+1])
                max += prices[i+1] - prices[i];
        }
        return max;
    }
}