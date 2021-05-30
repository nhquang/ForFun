//https://leetcode.com/problems/minimize-maximum-pair-sum-in-array/

public class Solution {
    public int MinPairSum(int[] nums) {
        Array.Sort(nums);
        int i = nums.Length / 2 - 1;
        int j = i + 1;
        int max = 0;
        while(i >= 0 && j < nums.Length){
            max = Math.Max(max, nums[i] + nums[j]);
            i--; j++;
        }
        return max;
    }
}