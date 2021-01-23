//https://leetcode.com/problems/longest-harmonious-subsequence/

public class Solution {
    public int FindLHS(int[] nums) {
        var set = new HashSet<int>();
        int max = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            set.Add(nums[i]);
            int sum1 = 0, sum2 = 0;
            if (set.Contains(nums[i] + 1))
                for (int j = 0; j <= i; j++) if (nums[j] == nums[i] || nums[j] == nums[i] + 1) sum1++;
			
            if (set.Contains(nums[i] - 1))
                for (int j = 0; j <= i; j++) if (nums[j] == nums[i] || nums[j] == nums[i] - 1) sum2++;
            max = Math.Max(Math.Max(sum1,sum2), max);
        }
        return max;
    }
}