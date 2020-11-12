	//https://leetcode.com/problems/remove-duplicates-from-sorted-array/
	
	
	
	public int RemoveDuplicates(int[] nums) {
        if (nums.Length <= 1) return nums.Length == 1 ? 1 : 0;
		int newLength = 0;
        for (int i = 1; i < nums.Length && nums[i] != int.MaxValue; i++)
        {
            if (nums[i] == nums[i - 1])
            {
                for (int j = i - 1; j < nums.Length - 1; j++)
                {
                    nums[j] = nums[j + 1];
                    nums[j + 1] = int.MaxValue;
                }
                i--;
            }
            else newLength++;
        }
        return newLength;
    }
	
	
	//better solution O(n) runtime
	
	public int RemoveDuplicates(int[] nums) {
        if (nums.Length <= 1) return nums.Length == 1 ? 1 : 0;
        int j = 0, newLength = 1;
        for(int i = 1; i < nums.Length; i++)
        {
            if(nums[i] != nums[j])
            {
                j++;
                nums[j] = nums[i];
                newLength++;
            }
        }
        return newLength;
    }