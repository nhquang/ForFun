	//https://leetcode.com/problems/contains-duplicate/
	
	
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