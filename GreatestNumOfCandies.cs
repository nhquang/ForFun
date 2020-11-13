	//https://leetcode.com/problems/kids-with-the-greatest-number-of-candies/
	
	
	
	
	public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        
        int largest = 0;
        var rslt = new List<bool>();
        for (int i = 0; i < candies.Length; i++)
        {
            if (candies[i] > largest) largest = candies[i];
        }
        for (int i = 0; i < candies.Length; i++)
        {
            if ((candies[i] + extraCandies) > largest) rslt.Add(true);
            else rslt.Add(false);
        }
        return rslt;
    }