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
	
	//O(n)
	public double FindMaxAverage(int[] nums, int k) {
        int temp = 0; double max = 0;
        for(int i = 0; i < k; i++)
            temp += nums[i];
        max = temp;
        int j = 0;
        for(int i = k; i < nums.Length;i++){
            temp = temp + nums[i] - nums[j];
            max = Math.Max(max, temp);
            j++;
        }
        return max / k;
        
    }
}