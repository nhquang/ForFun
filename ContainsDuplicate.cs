	//https://leetcode.com/problems/contains-duplicate/
	
	public class Solution {
		
		//O(n)
		public bool ContainsDuplicate(int[] nums) {
			var set = new HashSet<int>();
			for(int i = 0; i < nums.Length; i++){
				if(set.Contains(nums[i])) return true;
				else set.Add(nums[i]);
			}
			return false;
		}
		
		
		public bool ContainsDuplicate(int[] nums) {
			var distincts = new Dictionary<int,int>();
			foreach(var i in nums){
				if(distincts.ContainsKey(i)) distincts[i]++;
				else distincts.Add(i, 1);
			}
			foreach(var item in distincts)
				if(item.Value > 1) return true;
			return false;
		}
	}
	