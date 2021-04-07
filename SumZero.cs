//https://leetcode.com/problems/find-n-unique-integers-sum-up-to-zero/

public class Solution {
    public int[] SumZero(int n) { 
        var rslt= new int[n];
        int count = (n / 2) * -1;
        for(int i = 0; i < rslt.Length;i++) {
            if(n % 2 == 0 && count == 0) count++;
            rslt[i] = count++;
        }
        return rslt;
    }
}