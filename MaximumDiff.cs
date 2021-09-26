//https://leetcode.com/problems/maximum-difference-between-increasing-elements/

public class Solution {
    public int MaximumDifference(int[] nums) {
        int min = int.MaxValue, rs = -1;
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] < min)
                min = nums[i];
            else
                rs = Math.Max(rs, nums[i] - min);
        }
        return rs == 0 ? -1 : rs;
    }
}