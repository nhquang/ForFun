//https://leetcode.com/problems/minimum-operations-to-make-the-array-increasing/

public class Solution {
    public int MinOperations(int[] nums) {
        int rslt = 0;
        for(int i = 0; i < nums.Length - 1; i++){
            if(nums[i] >= nums[i+1]){
                rslt += (nums[i] + 1) - nums[i+1];
                nums[i+1] = nums[i] + 1;
            }
        }
        return rslt;
    }
}