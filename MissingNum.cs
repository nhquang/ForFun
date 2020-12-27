//https://leetcode.com/problems/missing-number/


public class Solution {
    public int MissingNumber(int[] nums) {
        int temp;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == int.MinValue) temp = 0;
            else temp = Math.Abs(nums[i]);
            
            if (temp < nums.Length && nums[temp] == 0) nums[temp] = int.MinValue;
            else if (temp < nums.Length) nums[temp] *= -1;
        }

        for (int i = 0; i < nums.Length; i++)
            if (nums[i] >= 0) return i;

        return nums.Length;
    }
}