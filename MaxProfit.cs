	//https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
	
	
	public int MaxProfit(int[] prices) {
        int max = 0;
        for(int i = 0; i < prices.Length - 1; i++){
            for(int j = i + 1; j < prices.Length; j++){
                if((prices[j] - prices[i]) > max) max = prices[j] - prices[i];
            }
        }
        return max;
    }