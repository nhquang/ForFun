//https://leetcode.com/problems/a-number-after-a-double-reversal/

public class Solution {
    public bool IsSameAfterReversals(int num) {
        if(num == 0)
            return true;
        return num % 10 != 0;
    }
}