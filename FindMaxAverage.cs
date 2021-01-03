//https://leetcode.com/problems/maximum-average-subarray-i/

public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        double max = int.MinValue;
        for (int i = 0; i < nums.Length; i++)
        {
            int temp = 0, j = i, sum = 0;
            if (j + k <= nums.Length)
            {
                while (temp < k)
                {
                    sum += nums[j];
                    temp++; j++;
                }
                max = Math.Max(max, sum);
            }
        }
        return max / k;
        
    }
}