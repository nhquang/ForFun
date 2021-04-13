//https://leetcode.com/problems/sign-of-the-product-of-an-array/

public class Solution {
    public int ArraySign(int[] nums) {
        int count = 0;
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] == 0) return 0;
            if(nums[i] < 0) count++;
        }
        return count % 2 == 0 ? 1 : -1;
    }
}