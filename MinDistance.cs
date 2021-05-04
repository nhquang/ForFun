//https://leetcode.com/problems/minimum-distance-to-the-target-element/

public class Solution {
    public int GetMinDistance(int[] nums, int target, int start) {
        int i = start,front = -1, back = -1;
        while(i >= 0){
            if(nums[i] == target) break;
            i--;
        }
        front = i < 0 ? int.MaxValue : start - i;
        i = start;
        while(i < nums.Length){
            if(nums[i] == target) break;
            i++;
        }
        back = i >= nums.Length ? int.MaxValue : i - start;
        return Math.Min(front,back);
    }
}