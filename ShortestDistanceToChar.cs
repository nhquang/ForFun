	//https://leetcode.com/problems/shortest-distance-to-a-character/
	
	
	
	public int[] ShortestToChar(string s, char c) {
        var rslt = new List<int>();
        for(int i = 0; i < s.Length; i++){
            int count1 = 0, count2 = 0;
            for(int j = i; j < s.Length && s[j] != c; j++){
                count1++;
                if(j == s.Length - 1) count1 = int.MaxValue;
            }
            for(int h = i; h >= 0 && s[h] != c; h--){
                count2++;
                if(h == 0) count2 = int.MaxValue;
            }
            rslt.Add(count1 < count2 ? count1 : count2);
        }
        return rslt.ToArray();
    }