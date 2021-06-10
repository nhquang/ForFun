//https://leetcode.com/problems/reduction-operations-to-make-the-array-elements-equal/

public class Solution {
    public int ReductionOperations(int[] nums) {
        int count = 0;
        int rs = 0;
        Array.Sort(nums);
        int smallest = nums[0], prev = nums[nums.Length - 1];
        for(int i = nums.Length - 1; i >= 0; i--){
            if(nums[i] != prev){
                rs += count;
                if(nums[i] == smallest) break;
            }
            count++;
            prev = nums[i];
        }
        return rs;
    }
}