	//https://leetcode.com/problems/special-array-with-x-elements-greater-than-or-equal-x/
	
	public int SpecialArray(int[] nums) {
        int temp = 0;
        for(int x = 0; x <= nums.Length; x++){
            for(int i = 0; i < nums.Length; i++){
                if(nums[i] >= x) temp++; 
            }
            if(temp == x) return x;
            else temp = 0;
        }
        return -1;
    }