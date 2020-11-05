	//https://leetcode.com/problems/element-appearing-more-than-25-in-sorted-array/
	
	public int FindSpecialInteger(int[] arr) {
        double target = (arr.Length * 25) / 100;
        var freq = new Dictionary<int,int>();
        foreach(var item in arr){
            if(freq.ContainsKey(item)) freq[item]++;
            else freq.Add(item, 1);
            if(freq[item] > target) return item;
        }
        
        
        return 0;
    }