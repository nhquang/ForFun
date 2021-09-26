//https://leetcode.com/problems/sum-of-beauty-in-the-array/


public class Solution {
    public int SumOfBeauties(int[] nums) {
        var leftDict = new Dictionary<int, int>();
        var leftSorted = new SortedSet<int>();
        var rightDict = new Dictionary<int,int>();
        var rightSorted = new SortedSet<int>();
        leftDict.Add(nums[0], 1);
        leftSorted.Add(nums[0]);
        for(int i = 2; i < nums.Length; i++){
            rightSorted.Add(nums[i]);
            if(rightDict.ContainsKey(nums[i])) rightDict[nums[i]]++;
            else rightDict.Add(nums[i], 1);
        }
        int rs = 0;
        for(int i = 1; i < nums.Length - 1; i++){
            if(nums[i] > leftSorted.Max && nums[i] < rightSorted.Min)
                rs += 2;
            else if(nums[i - 1] < nums[i] && nums[i] < nums[i + 1])
                rs++;
            leftSorted.Add(nums[i]);
            if(leftDict.ContainsKey(nums[i])) leftDict[nums[i]]++;
            else leftDict.Add(nums[i], 1);
            if(--rightDict[nums[i + 1]] == 0){
                rightDict.Remove(nums[i+1]);
                rightSorted.Remove(nums[i+1]);
            }
        }
        return rs;
    }
}