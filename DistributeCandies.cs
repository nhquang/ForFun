	//https://leetcode.com/problems/distribute-candies/
	
	public int DistributeCandies(int[] candies) {
        var distincts = new Dictionary<int,int>();
        foreach(var item in candies){
            if(distincts.ContainsKey(item)) distincts[item]++;
            else distincts.Add(item, 1);
        }
        
        if(distincts.Count >= candies.Length / 2){
            return candies.Length / 2;
        }
        else return distincts.Count;
        
    }