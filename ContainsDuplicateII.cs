//https://leetcode.com/problems/contains-duplicate-ii/




public class Solution {
	
	//sliding window
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        for(int i = 0; i < nums.Length; i++){
            for(int j = i+1; j < nums.Length; j++){
                if((j - i) > k) break; 
                if(nums[i] == nums[j])
                    return true;
            }
        }
        return false;
    }
	
	//O(n)
	public bool ContainsNearbyDuplicate(int[] nums, int k) {
        var dict = new Dictionary<int,int>();
        for(int i = 0; i < nums.Length; i++){
            if(dict.ContainsKey(nums[i])){
                if((i - dict[nums[i]]) <= k) return true;
                else dict[nums[i]] = i;
            }
            else dict.Add(nums[i], i);
        }
        return false;
    }
}