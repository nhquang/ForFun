//https://leetcode.com/problems/concatenation-of-array/

public class Solution {
    public int[] GetConcatenation(int[] nums) {
        var rs = new int[nums.Length * 2];
        int i = 0, j = rs.Length / 2;
        for(int k = 0; k < nums.Length; k++){
            rs[i++] = nums[k];
            rs[j++] = nums[k];
        }
        return rs;
    }
}