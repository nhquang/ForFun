//https://leetcode.com/problems/largest-number-at-least-twice-of-others/


public class Solution {
    public int DominantIndex(int[] nums) {
        int max = int.MinValue, idex = int.MinValue;
        for(int i = 0; i < nums.Length;i++){
            if(nums[i] > max){ max = nums[i]; idex = i; }
        }
        foreach(var item in nums){
            if(max != item && (max - item < item)) return -1;
        }
        return idex;
    }
}