//https://leetcode.com/problems/count-number-of-pairs-with-absolute-difference-k/

public class Solution {
    public int CountKDifference(int[] nums, int k) {
        var dict = new Dictionary<int, int>();
        int rs = 0;
        for(int i = 0; i < nums.Length; i++){
            if(dict.ContainsKey(nums[i] + k)) rs += dict[nums[i] + k];
            if(dict.ContainsKey(nums[i] - k)) rs += dict[nums[i] - k];
            if(dict.ContainsKey(nums[i])) dict[nums[i]]++;
            else dict.Add(nums[i], 1);
        }
        return rs;
    }
}