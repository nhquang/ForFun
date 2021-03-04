//https://leetcode.com/problems/power-of-four/

public class Solution {
    public bool IsPowerOfFour(int num) {
        if(num == 1) return true;
        if(num == 0) return false;
        while(num != 1){
            if(num % 4 != 0) return false;
            num /= 4;
        }
        return true;
    }
}