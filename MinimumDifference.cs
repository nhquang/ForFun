//https://leetcode.com/problems/minimum-difference-between-highest-and-lowest-of-k-scores/

public class Solution {
    public int MinimumDifference(int[] nums, int k) {
        if(nums.Length == 1) return 0;
        Array.Sort(nums);
        int prev = nums[0], rs = int.MaxValue;
        int temp = k - 1;
        for(int i = 0; i < nums.Length && temp < nums.Length; i++){
            rs = Math.Min(nums[temp++] - nums[i], rs);
        }
        temp = nums.Length - k;
        for(int i = nums.Length - 1; i >= 0 && temp >= 0; i--){
            rs = Math.Min(nums[i] - nums[temp--], rs);
        } 
        return rs;
    }
}