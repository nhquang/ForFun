//https://leetcode.com/problems/maximum-product-of-three-numbers/

public class Solution {
    public int MaximumProduct(int[] nums) {
        Array.Sort(nums);
        int max1 = 1, max2 = 1;
        max1 *= nums[0] * nums[1] * nums[nums.Length - 1];
        max2 *= nums[nums.Length - 1] * nums[nums.Length - 2] * nums[nums.Length - 3];
        return Math.Max(max1, max2);
    }
}