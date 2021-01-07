//https://leetcode.com/problems/set-mismatch/



public class Solution {
	
	//O(n)
	public int[] FindErrorNums(int[] nums) {
        int[] rslt = new int[2];
        var set = new HashSet<int>();
        for(int i = 0; i < nums.Length; i++){
            if(set.Contains(nums[i])) rslt[0] = nums[i];
            else set.Add(nums[i]);
        }
        for(int i = 1; i <= nums.Length; i++){
            if(!set.Contains(i)) rslt[1] = i;
        }
        return rslt;
    }
	
	//0(n)without using extra space
    public int[] FindErrorNums(int[] nums) {
        int[] rslt = new int[2];
        for(int i = 0; i < nums.Length; i++){
            if(nums[Math.Abs(nums[i]) - 1] < 0) rslt[0] = Math.Abs(nums[i]);
            else nums[Math.Abs(nums[i]) - 1] *= -1;
        }
        for(int i = 0; i < nums.Length; i++)
            if(nums[i] > 0)
                rslt[1] = i + 1;
        return rslt;
    }
}