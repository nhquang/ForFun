//https://leetcode.com/problems/how-many-numbers-are-smaller-than-the-current-number/


public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        var rslt = new List<int>();
        for(int i = 0; i < nums.Length; i++){
            int temp = 0;
            for(int j = 0; j < nums.Length; j++)
                if(nums[j] < nums[i]) temp++;
            
            rslt.Add(temp);
        }
        return rslt.ToArray();
    }
}