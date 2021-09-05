//https://leetcode.com/problems/count-special-quadruplets/

public class Solution {
    public int CountQuadruplets(int[] nums) {
        var dict = new Dictionary<int, List<int>>();
        for(int i = 0; i < nums.Length; i++){
            if(dict.ContainsKey(nums[i])) dict[nums[i]].Add(i);
            else dict.Add(nums[i], new List<int>(){i});
        }
        int rs = 0;
        for(int i = 0; i < nums.Length - 3; i++){
            for(int j = i + 1; j < nums.Length - 2; j++){
                for(int k = j + 1; k < nums.Length - 1; k++){
                    if(dict.ContainsKey(nums[i] + nums[j] + nums[k])){
                        foreach(var item in dict[nums[i] + nums[j] + nums[k]])
                            if(item > k) rs++;
                    }
                }
            }
        }
        return rs;
    }
}