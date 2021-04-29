//https://leetcode.com/problems/summary-ranges/

public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        var rslt = new List<string>();
        if(nums.Length == 0) return rslt;
        int start = int.MinValue;
        bool temp = true;
        for(int i = 0; i < nums.Length - 1; i++){
            if(nums[i] + 1 == nums[i+1] && temp){
                start = nums[i];
                temp = false;
            }
            else if (nums[i] + 1 != nums[i+1] && temp) rslt.Add(nums[i].ToString());
            else if (nums[i] + 1 != nums[i+1]){
                temp = true;
                rslt.Add(start + "->" + nums[i]);
            }
        }
        if(temp) rslt.Add(nums[nums.Length - 1].ToString());
        else rslt.Add(start + "->" + nums[nums.Length - 1]);
        return rslt;
    }
}