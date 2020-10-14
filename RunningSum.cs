	//https://leetcode.com/problems/running-sum-of-1d-array/
	
	public int[] RunningSum(int[] nums) {
        int sum = 0;
        for(int i = 0; i < nums.Length;i++){
            sum += nums[i];
            nums[i] = sum;
        }
        return nums;
    }