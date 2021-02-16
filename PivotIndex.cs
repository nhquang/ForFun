//https://leetcode.com/problems/find-pivot-index/
public class Solution {
    public int PivotIndex(int[] nums) {
        int[] left = new int[nums.Length];
        int[] right = new int[nums.Length];
        for(int i = nums.Length - 1; i >= 0; i--){
            if(i == nums.Length - 1) right[i] = nums[nums.Length - 1];
            else right[i] = nums[i] + right[i+1];
        }
        for(int i = 0; i < nums.Length; i++){
            if(i == 0) left[i] = nums[i];
            else left[i] = nums[i] + left[i-1];
            if(left[i] == right[i]) return i;
        }
        return -1;
    }
}