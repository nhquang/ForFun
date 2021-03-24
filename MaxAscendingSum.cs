//https://leetcode.com/problems/maximum-ascending-subarray-sum/


public class Solution {
    public int MaxAscendingSum(int[] nums) {
        int max = -1, sum = 0, prev = -1;
        for(int i = 0; i < nums.Length; ++i){
            if(nums[i] > prev) sum += nums[i];
            else if(nums[i] <= prev) sum = nums[i];
            max = Math.Max(max, sum);
            prev = nums[i];
        }
        return max;
    }
}