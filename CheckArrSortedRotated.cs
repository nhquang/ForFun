//https://leetcode.com/problems/check-if-array-is-sorted-and-rotated/

public class Solution {
    public bool Check(int[] nums) {
        int start = nums[0], prev = nums[0];
        bool temp = false;
        for(int i = 1; i < nums.Length; i++){
            if(!temp && nums[i] < prev) temp = true;
            else if (temp && (nums[i] < prev || nums[i] > start)) return false;
            prev = nums[i];
        }
        if(temp && nums.Length > 2 && nums[nums.Length - 1] > start) return false;
        return true;
    }
}