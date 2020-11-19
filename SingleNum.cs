//https://leetcode.com/problems/single-number/


public class Solution {
    public int SingleNumber(int[] nums) {
        var dict = new Dictionary<int,int>();
        for(int i = 0; i < nums.Length; i++){
            if(dict.ContainsKey(nums[i])) dict[nums[i]]++;
            else dict.Add(nums[i], 1);
        }
        foreach(var item in dict){
            if(item.Value < 2) return item.Key;
        }
        return -1;
        
    }
}