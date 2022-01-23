//https://leetcode.com/problems/minimum-cost-of-buying-candies-with-discount/

public class Solution {
    public int MinimumCost(int[] cost) {
        Array.Sort(cost);
        int rs = 0, count = 0;
        for(int i = cost.Length - 1; i >= 0; i--){
            if(count == 2)
                count = 0;
            else{
                rs += cost[i];
                count++;
            }
        }
        return rs;
    }
}