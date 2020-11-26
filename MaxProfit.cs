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
	
	
	//better solution O(n)
	
	public int MaxProfit(int[] prices) {
        int max = 0, minprice = Int32.MaxValue;
        for(int i = 0; i < prices.Length; i++){
            if(minprice > prices[i]) minprice = prices[i];
            else{
                if((prices[i] - minprice) > max) max = prices[i] - minprice;
            }
        }
        return max;
        
    }