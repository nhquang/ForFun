//https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/


public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        var rslt = new List<int>();
        for(int i = 0; i < nums.Length; i++)
            if(nums[Math.Abs(nums[i]) - 1] > 0) nums[Math.Abs(nums[i]) - 1] *= -1;
        
        for(int i = 0; i < nums.Length; i++)
            if(nums[i] > 0) rslt.Add(i+1);
        
        return rslt;
    }
}