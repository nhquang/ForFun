//https://leetcode.com/problems/set-mismatch/



public class Solution {
    public int[] FindErrorNums(int[] nums) {
        int[] rslt = new int[2];
        for(int i = 0; i < nums.Length; i++){
            if(nums[Math.Abs(nums[i]) - 1] < 0) rslt[0] = Math.Abs(nums[i]);
            else nums[Math.Abs(nums[i]) - 1] *= -1;
        }
        for(int i = 0; i < nums.Length; i++)
            if(nums[i] > 0)
                rslt[1] = i + 1;
        return rslt;
    }
}