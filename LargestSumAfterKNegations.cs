//

public class Solution {
    public int LargestSumAfterKNegations(int[] nums, int k) {
        Array.Sort(nums);
        int i = 0;
        bool neg = nums[i] < 0;
        while(k > 0){
            if(neg){
                if(nums[i] > 0 && k % 2 != 0 &&  nums[i] > nums[i-1]) i--;
                nums[i] *= -1;
                i++; k--;
            }
            else{
                nums[i] *= -1;
                k--;
            }
        }
        int rs = 0;
        foreach(var item in nums) rs += item;
        return rs;
    }
}