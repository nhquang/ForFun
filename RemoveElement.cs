public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int i = 0, j = nums.Length - 1, len = 0;
        while(i <= j){
            if(nums[i] == val){
                while(i < j){
                    if(nums[j] == val) j--;
                    else break;
                }
                if(i >= j) break;
                int temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
                len++;
            }
            else len++;
            i++;
        }
        return len;
    }
}