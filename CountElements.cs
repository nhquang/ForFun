//https://leetcode.com/problems/count-elements-with-strictly-smaller-and-greater-elements/


public class Solution {
    public int CountElements(int[] nums) {
        Array.Sort(nums);
        int rs = 0;
        for(int i = 1; i < nums.Length - 1; i++){
            if(nums[i] > nums[0] && nums[i] < nums[nums.Length - 1])
                rs++;
        }
        return rs;
    }
}