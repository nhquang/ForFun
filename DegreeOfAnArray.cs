//https://leetcode.com/problems/degree-of-an-array/


public class Solution {
    public int FindShortestSubArray(int[] nums) {
        var dict = new Dictionary<int,int>();
        for(int i = 0; i < nums.Length; i++){										//find frequency of each num
            if(dict.ContainsKey(nums[i])) dict[nums[i]]++;
            else dict.Add(nums[i],1);
        }
        int maxFreq = int.MinValue, maxKey = 0;
        var set = new HashSet<int>();
        foreach(var item in dict){													//store nums with highest frequency in a HashSet
            if(item.Value > maxFreq){
                set.Clear();
                maxFreq = item.Value;
                set.Add(item.Key);
            }
            else if(item.Value == maxFreq) set.Add(item.Key);
        }
        if(maxFreq == 1) return 1;
        int minLength = int.MaxValue;
        for(int i = 0; i < nums.Length;i++){										//calculate shortest subarray  
            if(set.Contains(nums[i])){
                for(int j = nums.Length - 1; j > i; j--){
                    if(nums[j] == nums[i]){
                        if((j - i + 1) < minLength) minLength = j - i + 1;
                        break;
                    }
                }
                set.Remove(nums[i]);
            }
        }
        return minLength;
    }
}