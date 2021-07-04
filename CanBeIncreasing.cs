//https://leetcode.com/problems/remove-one-element-to-make-the-array-strictly-increasing/

public class Solution {
    public bool CanBeIncreasing(int[] nums) {
        int prev = 0, count = 0;
        for(int i = 0; i < nums.Length;i++){
            if(nums[i] <= prev) {
                if(count == 1) return false;
                var temp = new int[nums.Length - 1];
                int h = 0;
                for(int j = 0; j < temp.Length; j++){
                    if(h != i) temp[j] = nums[h];
                    else j--;
                    h++;
                }
                var a = check(temp);
                h = 0;
                for(int j = 0; j < temp.Length; j++){
                    if(h != i - 1) temp[j] = nums[h];
                    else j--;
                    h++;
                }
                var b = check(temp);
                if(a || b) count++;
                else return false;
            }
            prev = nums[i];
        }
        return true;
    }
    bool check(int[] nums){
        int prev = 0;
        for(int i = 0; i < nums.Length;i++){
            if(nums[i] <= prev) return false;
            prev = nums[i];
        }
        return true;
    }
}