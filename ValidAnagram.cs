	//https://leetcode.com/problems/valid-anagram/solution/
	
	
	public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;
        var sArr = s.ToCharArray();
        var tArr = t.ToCharArray();
        Array.Sort(sArr);
        Array.Sort(tArr);
        for(int i = 0; i < s.Length; i++)
            if (sArr[i] != tArr[i]) return false;
        return true;
    }