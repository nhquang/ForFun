//https://leetcode.com/problems/sort-array-by-increasing-frequency/



public class Solution {
    public int[] FrequencySort(int[] nums) {
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(nums[i])) dict[nums[i]]++;
            else dict.Add(nums[i], 1);
        }
        var rslt = new List<int>();
        var temp = dict.OrderBy(i => i.Value).ThenByDescending(i => i.Key);

        foreach(var item in temp)
            for(int i = 0; i < item.Value; i++)
                rslt.Add(item.Key);

        return rslt.ToArray();
    }
}
