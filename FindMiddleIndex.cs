//https://leetcode.com/problems/find-the-middle-index-in-array/

public class Solution {
    public int FindMiddleIndex(int[] nums) {
        int[] left = new int[nums.Length], right = new int[nums.Length];
        int sum = 0;
        for(int i = nums.Length - 1; i >= 0; i--){
            sum += nums[i];
            left[i] = sum;
        }
        sum = 0;
        for(int i = 0; i < nums.Length; i++){
            sum += nums[i];
            right[i] = sum;
        }
        for(int i = 0; i < nums.Length; i++)
            if(left[i] == right[i])
                return i;
        return -1;
    }
}