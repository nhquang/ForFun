//https://leetcode.com/problems/maximum-number-of-coins-you-can-get/

public class Solution {
    public int MaxCoins(int[] piles) {
        Array.Sort(piles);
        int sum = 0, picks = 0;
        for(int i = piles.Length - 2; i > picks; i-=2){
            sum += piles[i];
            picks++;
        }
        return sum;
    }
}