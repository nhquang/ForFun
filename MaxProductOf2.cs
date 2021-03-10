//https://leetcode.com/problems/maximum-product-of-two-elements-in-an-array/

public class Solution {
    public int MaxProduct(int[] nums) {
        int max1 = int.MinValue, max2 = int.MinValue;
        for(int i = 0; i < nums.Length; i++){
            if(max1 < nums[i]){
                max2 = max1;
                max1 = nums[i];
            }
            else if(max2 < nums[i])
                max2 = nums[i];
        }
        return (max1 - 1) * (max2 - 1);
    }
}