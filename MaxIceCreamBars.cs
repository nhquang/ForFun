//https://leetcode.com/problems/maximum-ice-cream-bars/

public class Solution {
    public int MaxIceCream(int[] costs, int coins) {
        Array.Sort(costs);
        int sum = 0, noOfBars = 0;
        for(int i = 0; i < costs.Length; i++){
            sum += costs[i];
            if(sum <= coins) noOfBars++;
            else break;
        }
        return noOfBars;
    }
}