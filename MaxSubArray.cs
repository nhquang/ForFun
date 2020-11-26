//https://leetcode.com/problems/maximum-subarray/



public class Solution {
    public int MaxSubArray(int[] nums) {
        
        int currSum = nums[0], globSum = nums[0];
        for(int i = 1; i < nums.Length; i++){
            currSum = Math.Max(nums[i], currSum + nums[i]);
            globSum = Math.Max(currSum, globSum);
        }
        return globSum;
    }
}