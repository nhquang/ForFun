//https://leetcode.com/problems/arranging-coins/

public class Solution {
    public int ArrangeCoins(int n) {
        int i;
        for(i = 1; i <= n; i++){
            n -= i;
            if(n < 0) return i-1;
        }
        return i-1;
    }
}