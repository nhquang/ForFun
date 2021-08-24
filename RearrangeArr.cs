//https://leetcode.com/problems/array-with-elements-not-equal-to-average-of-neighbors/

public class Solution {
    public int[] RearrangeArray(int[] nums) {
        Array.Sort(nums);
        var rs = new int[nums.Length];
        int larger = nums.Length - 1, smaller = 0;
        bool small = true;
        for(int i = 0; i < rs.Length; i++){
            if(small){
                rs[i] = nums[smaller++];
                small = !small;
            }
            else {
                rs[i] = nums[larger--];
                small = !small;
            }
        }
        return rs;
    }
}