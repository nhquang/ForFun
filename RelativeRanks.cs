//https://leetcode.com/problems/relative-ranks/


public class Solution {
    public string[] FindRelativeRanks(int[] nums) {
        var copy = new int[nums.Length];
        var rslt = new string[nums.Length];
        for(int i = 0; i < nums.Length; i++) copy[i] = nums[i];
        //copy = nums;
        Array.Sort(nums);
        Array.Reverse(nums);
        var dict = new Dictionary<int,int>();
        for(int i = 0; i < nums.Length; i++)
            dict.Add(nums[i], i + 1);
        for(int i = 0; i < nums.Length; i++){
            if(dict[copy[i]] == 1) rslt[i] = "Gold Medal";
            else if (dict[copy[i]] == 2) rslt[i] = "Silver Medal";
            else if (dict[copy[i]] == 3) rslt[i] = "Bronze Medal";
            else rslt[i] = dict[copy[i]].ToString();
        }
        return rslt;
    }
}