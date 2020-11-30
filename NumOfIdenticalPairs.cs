//https://leetcode.com/problems/number-of-good-pairs/



public class Solution {
    public int NumIdenticalPairs(int[] nums) {
        int count = 0;
        for(int i = 0; i < nums.Length; i++){
            for(int j = i - 1; j >= 0; j--){
                if(nums[i] == nums[j]) count++;
            }
        }
        return count;
    }
}