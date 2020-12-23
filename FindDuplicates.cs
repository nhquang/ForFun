//https://leetcode.com/problems/find-all-duplicates-in-an-array/

public class Solution {
    public IList<int> FindDuplicates(int[] nums) {
        var rslt = new List<int>();
        for(int i = 0; i < nums.Length; i++){
            if(nums[Math.Abs(nums[i]) - 1] > 0) nums[Math.Abs(nums[i]) - 1] *= -1;
            else rslt.Add(Math.Abs(nums[i]));
        }

        return rslt;
    }
}