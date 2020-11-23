//https://leetcode.com/problems/non-decreasing-array/




public class Solution {
    public bool CheckPossibility(int[] nums) {
        int count = 0;
        for(int i = 0; i < nums.Length - 1; i++){
            
            if (nums[i] > nums[i + 1])
            {
                count++;
                if (count > 1) return false;
                if(i == 0) nums[i] = nums[i+1];
                else if(i == nums.Length - 2){
                    nums[i+1] = nums[i];
                }
                else{
                    if(nums[i+1] >= nums[i-1]) nums[i] = nums[i+1];
                    else if(nums[i] <= nums[i+2]) nums[i+1] = nums[i];
                    else return false;
                }
                    
            }
        }
        return true;
    }
}