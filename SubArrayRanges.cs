//https://leetcode.com/problems/sum-of-subarray-ranges/

public class Solution {
    public long SubArrayRanges(int[] nums) {
        long rs = 0;
        int distance = 1;
        var maxes = new long[nums.Length];
        var mins = new long[nums.Length];
        while(distance < nums.Length){
            for(int i = 0; i < nums.Length; i++){
                if(i + distance < nums.Length && distance == 1){
                    long max = (long) nums[i], min = (long)nums[i];
                    for(int j = i; j <= i + distance; j++){
                        max = Math.Max(max, nums[j]);
                        min = Math.Min(min, nums[j]);
                    }
                    maxes[i] = max;
                    mins[i] = min;
                    rs += max - min;
                }
                else if (i + distance < nums.Length){
                    maxes[i] = Math.Max(maxes[i], nums[i + distance]);
                    mins[i] = Math.Min(mins[i], nums[i + distance]);
                    rs += maxes[i] - mins[i];
                }
                    
            }
            distance++;
        }
        return rs;
    }
}