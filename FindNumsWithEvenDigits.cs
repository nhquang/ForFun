	//https://leetcode.com/problems/find-numbers-with-even-number-of-digits/



	public int FindNumbers(int[] nums) {
        int count = 0;
        
        for(int i = 0; i < nums.Length; i++){
            //if(nums[i].ToString().Length % 2 == 0) count++;
            int count2 = 1;
            while(nums[i] != 0){
                nums[i] /= 10;
                if(nums[i] == 0)
                    if(count2 % 2 == 0) count++;
                count2++;
            }
        }
        return count;
    }