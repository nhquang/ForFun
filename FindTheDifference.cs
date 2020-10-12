	//https://leetcode.com/problems/find-the-difference/
	
	public char FindTheDifference(string s, string t) {
        s = String.Join("", s.OrderBy(c => c));

        t = String.Join("", t.OrderBy(c => c));
        for(int i = 0; i < s.Length; i++){
            if(s[i] != t[i]) return t[i];
            else if(i == s.Length - 1) return t[i+1];
            
        }
        return t[0];
    }