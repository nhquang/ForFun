//https://leetcode.com/problems/longest-continuous-increasing-subsequence/

public class Solution {
    public int FindLengthOfLCIS(int[] nums) {
        int count = 1, max = 1;
        if(nums.Length == 0) return 0;
        for(int i = 1; i < nums.Length; i++){
            if(nums[i-1] >= nums[i]){
                max = Math.Max(count, max);
                count = 1;
            }
            else count++;
        }
        max = Math.Max(max, count);
        return max;
    }
}