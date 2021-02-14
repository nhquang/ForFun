//https://leetcode.com/problems/product-of-array-except-self/

public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var prods2 = new int[nums.Length];
        var prods1 = new int[nums.Length];
        prods1[0] = prods2[nums.Length-1] = 1;
        for(int i = 1; i < nums.Length; i++)
            prods1[i] = nums[i-1] * prods1[i-1];
        for(int i = nums.Length - 2; i >= 0; i--)
            prods2[i] = nums[i+1] * prods2[i+1];
        for(int i = 0; i < nums.Length;i++){
            nums[i] = prods1[i] * prods2[i];
        }
        return nums;
    }
}