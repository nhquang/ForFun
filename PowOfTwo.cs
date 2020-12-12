//https://leetcode.com/problems/power-of-two/



public class Solution {
    public bool IsPowerOfTwo(int n) {
        double temp = 0;
        int i = 0;
        while(temp < n){
            temp = Math.Pow(2,i);
            if(temp == n) return true;
            i++;
        }
        return false;
    }
}