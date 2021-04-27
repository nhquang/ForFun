//https://leetcode.com/problems/calculate-money-in-leetcode-bank/

public class Solution {
    public int TotalMoney(int n) {
        int j = 0, h = 1, sum = 0;
        for(int i = 1; i <= n; i++){
            if(h == 8){ j++; h = 1; }
            sum += h + j; h++;
        }
        return sum;
    }
}