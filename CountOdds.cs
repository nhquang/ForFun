//https://leetcode.com/problems/count-odd-numbers-in-an-interval-range/

public class Solution {
    public int CountOdds(int low, int high) {
        if((high - low + 1) % 2 == 0) return (high - low + 1) / 2;
        else{
            if(low % 2 == 0) return (high - low) / 2; 
            else return (high - low) / 2 + 1; 
        }
    }
}