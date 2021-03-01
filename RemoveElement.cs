public class Solution {
    public int RemoveElement(int[] nums, int val) {
        if (nums.Length == 0) return 0;
        int j = nums.Length - 1;
        if (j == 0) return nums[0] == val ? 0 : 1;
        int length = nums.Length;
        for (int i = 0; i < nums.Length; i++)
        {
            if (i >= j) break;
            if(nums[i] == val)
            {
                while (j > i && nums[j] == val) j--;
                if (j == i)
                {
                    if (j == 0) return 0;
                    else break;
                }
                int temp = nums[j];
                nums[j] = nums[i];
                nums[i] = temp;
                while (j > i && nums[j] == val) j--;
            }
        }
        for (int i = nums.Length - 1; i >= 0; i--) if (nums[i] == val) length--;
        return length;
    }
}