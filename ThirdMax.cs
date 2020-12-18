//https://leetcode.com/problems/third-maximum-number/

public class Solution {
    public int ThirdMax(int[] nums) {
        int? first = nums[0], second = null, third = null;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == first || nums[i] == second || nums[i] == third) continue;
            if (first <= nums[i])
            {
                third = second;
                second = first;
                first = nums[i];
            }
            else if (second <= nums[i] || second == null)
            {
                third = second;
                second = nums[i];
            }
            else if (third <= nums[i] || third == null) third = nums[i];
        }
        return third.HasValue ? third.Value : first.Value;
    }
}