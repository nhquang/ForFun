//https://leetcode.com/problems/array-partition-i/

public class Solution {
    public int ArrayPairSum(int[] nums) {
        Array.Sort(nums);
        int sum = 0;
        for(int i = nums.Length - 2; i >= 0; i--){
            sum += nums[i];
            i--;
        }
        return sum;
    }
}