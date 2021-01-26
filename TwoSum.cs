
public class Solution {
    //O(n)
	public int[] TwoSum(int[] nums, int target) {
        var dict = new Dictionary<int,int>();
        for(int i = 0; i < nums.Length; i++){
            int temp = target - nums[i];
            if(dict.ContainsKey(temp)) return new int[2]{dict[temp], i};
            else dict.Add(nums[i],i);
        }
        return new int[2]{0,0};
    }
	//O(n2)
	public int[] TwoSum(int[] nums, int target)
	{
		for (int i = 0; i < nums.Length; i++)
			for (int j = i + 1; j < nums.Length; j++)
				if (nums[i] + nums[j] == target) return new int[2] { i, j };
		return new int[2] { 0, 0 };
	}
}
//https://leetcode.com/problems/two-sum/