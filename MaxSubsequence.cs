//https://leetcode.com/problems/find-subsequence-of-length-k-with-the-largest-sum/


public class Solution {
    public int[] MaxSubsequence(int[] nums, int k) {
        var copy = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++)
            copy[i] = nums[i];
        Array.Sort(nums);
        var temp = new int[k];
        var rs = new int[k];
        int j = nums.Length - 1;
        for(int i = 0; i < k && j >= 0; i++){
            temp[i] = nums[j--];
        }
        var dict = new Dictionary<int,int>();
        for(int i = 0; i < temp.Length; i++){
            if(dict.ContainsKey(temp[i])) dict[temp[i]]++;
            else dict.Add(temp[i], 1);
        }
        j = 0;
        foreach(var item in copy){
            if(temp.Contains(item) && j < k && dict[item] > 0){
                rs[j++] = item;
                dict[item]--;
            }
        }
        return rs;
    }
}