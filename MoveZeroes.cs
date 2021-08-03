//https://leetcode.com/problems/move-zeroes/
	

public class Solution {
	//O(n2)
	public void MoveZeroes(int[] nums) {
        for(int i = 0; i < nums.Length - i; i++){
            for(int j = 0; j < nums.Length - 1; j++){
                if(nums[j] == 0 && nums[j+1] != 0){
                    int temp = nums[j+1];
                    nums[j+1] = nums[j];
                    nums[j] = temp;
                }
            }
        }
    }
	//O(n)
    public void MoveZeroes(int[] nums) {
        int a = 0;
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] != 0)
                nums[a++] = nums[i]; 
        }
        while(a < nums.Length)
            nums[a++] = 0;
    }
}	