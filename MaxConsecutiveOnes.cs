//https://leetcode.com/problems/max-consecutive-ones/


public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int max = 0, curr = 0;
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] == 1) curr++;
            else curr = 0;
            max = Math.Max(curr, max);
        }
        return max;
    }
}