//https://leetcode.com/problems/check-if-all-1s-are-at-least-length-k-places-away/


public class Solution {
    public bool KLengthApart(int[] nums, int k) {
        int count = k;
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] == 1){
                if(count < k) return false;
                count = 0;
            }
            else count++;
        }
        return true;
    }
}