//https://leetcode.com/problems/find-greatest-common-divisor-of-array/

public class Solution {
    public int FindGCD(int[] nums) {
        int min = nums[0], max = nums[0];
        for(int i = 0; i < nums.Length; i++){
            min = Math.Min(nums[i], min);
            max = Math.Max(nums[i], max);
        }
        int div = min;
        while(div > 1){
            if(min % div == 0 && max % div == 0)
                return div;
            div--;
        }
        return 1;
    }
}