//https://leetcode.com/problems/sum-of-unique-elements/

public class Solution {
    public int SumOfUnique(int[] nums) {
        var dict = new Dictionary<int,int>();
        int sum = 0;
        for(int i = 0; i < nums.Length; i++){
            if(dict.ContainsKey(nums[i])) dict[nums[i]]++;
            else dict.Add(nums[i], 1);
        }
        foreach(var item in dict)
            if(item.Value == 1) sum+=item.Key;
        return sum;
    }
}