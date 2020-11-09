	//https://leetcode.com/problems/majority-element/



	public int MajorityElement(int[] nums) {
        var occurrences = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++){
            if(occurrences.ContainsKey(nums[i])) occurrences[nums[i]]++;
            else occurrences.Add(nums[i], 1);
        }
        int temp = nums.Length / 2;
        foreach(var item in occurrences){
            if(item.Value > temp) return item.Key;
        }
        return 0;
    }